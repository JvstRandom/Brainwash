using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl4 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            triggerTidur.level4 = true;
            triggerCutsceneMakan.cutscene = true;
            Debug.Log("status lvl 4 = " + triggerTidur.level4);
        }
    }
}
