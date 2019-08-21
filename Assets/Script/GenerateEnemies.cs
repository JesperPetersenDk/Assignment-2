using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject spawnee;
    public float SpawnTime;
    public float spawnDeplay;

    // Start is called before the first frame update
    void Start()
    {
        //Kalder på vores "SpawnObject"
        InvokeRepeating("SpawnObject", SpawnTime, spawnDeplay);
    }

    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        //stopper kaldet til spawnObject.
        CancelInvoke("SpawnObject");
    }
}
