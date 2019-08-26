using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioSource collectSound;


    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Cube"))
        //{
            collectSound.Play();
            Counter.count += 1;
            Destroy(this);
        //}
    }
}
