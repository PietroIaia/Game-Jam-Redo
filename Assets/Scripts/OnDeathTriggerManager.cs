using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathTriggerManager : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) 
    {   
        if ( other.gameObject.name == "Death Trigger" ) {
            transform.position = new Vector3(-5.47f, -2.37f, 0);
        }
    }
}
