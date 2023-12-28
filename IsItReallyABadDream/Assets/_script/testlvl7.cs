using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl7 : MonoBehaviour
{
   
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            triggerSleseLevel6.level7 = true;
            Debug.Log("status lvl 7 = " + triggerSleseLevel6.level7);
        }
    }
}
