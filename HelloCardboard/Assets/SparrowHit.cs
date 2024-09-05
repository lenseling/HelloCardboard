using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowHit : MonoBehaviour
{
    public float flyOffSpeed = 10f;   // Speed at which the sparrow flies off
    private bool isFlyingOff = false; // To ensure the sparrow only flies off once
    AudioSource audioData;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        // If the sparrow is set to fly off, move it upwards
        if (isFlyingOff)
        {
            transform.Translate(Vector3.up * flyOffSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a tomato
        if (collision.gameObject.CompareTag("Tomato"))
        {
            FlyOff();
            gameManager.UpdateScore(1);
        }
    }

    private void FlyOff()
    {
        if (!isFlyingOff)
        {
            isFlyingOff = true;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Destroy(gameObject, 100); // Destroy sparrow after it flies off and sound plays
        }
    }
}
