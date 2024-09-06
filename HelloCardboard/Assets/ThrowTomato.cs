using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AudioSource))]
public class ThrowTomato : MonoBehaviour
{
    AudioSource audioData;
    public TomatoPrefab tomatoPrefab;
    private float lastSpawnTime = 0f;
    public float spawnDelay = 0.2f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Touchscreen.current.press.isPressed && Time.time > lastSpawnTime + spawnDelay)
        {
            lastSpawnTime = Time.time;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            TomatoPrefab tomato = Instantiate<TomatoPrefab>(tomatoPrefab);
            tomato.transform.localPosition = transform.position;
            tomato.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward *
                UnityEngine.Random.Range(500, 750));
        }
    }
}
