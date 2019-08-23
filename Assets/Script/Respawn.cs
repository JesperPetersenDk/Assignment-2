using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject car;

    public void OnClickNow()
    {
        print("hello world");

        Instantiate(car,
             new Vector3(0, 0, 0),
             Quaternion.identity);
    }
}
