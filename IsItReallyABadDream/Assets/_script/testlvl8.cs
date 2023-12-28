using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl8 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            triggerTidur.level8 = true;
            Debug.Log("status lvl 8 = " + triggerTidur.level8);
        }
    }
}
