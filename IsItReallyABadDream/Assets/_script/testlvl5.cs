using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl5 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            bukuZach.level5 = true;
            Debug.Log("status lvl 5 = " + bukuZach.level5);
        }
    }
}
