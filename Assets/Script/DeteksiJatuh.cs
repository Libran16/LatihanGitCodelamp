using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteksiJatuh : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10f)
        {
            Debug.Log("Player Jatuh");
        }
    }
}
