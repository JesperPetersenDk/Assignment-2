using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public void OnClickF()
    {
        var check = Input.GetKeyDown(KeyCode.F);
        if (check)
        {
            print("hello world");
        }
    }
}
