using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl6 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            triggerTidur.level6 = true;
            Debug.Log("status lvl 2 = " + triggerTidur.level6);
        }
    }
}
