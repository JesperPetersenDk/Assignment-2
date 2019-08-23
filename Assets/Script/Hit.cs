using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioSource collectSound;


    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Counter.count += 1;
        Destroy(gameObject);
    }
}
