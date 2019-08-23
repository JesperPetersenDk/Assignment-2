using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    //public void OnTriggerExit(Collider other)
    //{
    //    print("exit");
    //}

    void OnTriggerEnter(Collider item)
    {
        if(item.gameObject.tag == "Player")
        {
            print("Picked up");
            //Destroy(gameObject);
        }
    }
}
