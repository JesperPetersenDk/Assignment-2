using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject scoretext;
    public static int count;

    void Update()
    {
        scoretext.GetComponent<Text>().text = "Count: " + count;
    }
}
