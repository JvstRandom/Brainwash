using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl9 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            ObjectImage.level9 = true;
            PlayerManager.haveKeyLabirin=true;
            PlayerManager.haveMapLabirin=true;
            PlayerManager.haveKey = true;
            Debug.Log("status lvl 9 = " + ObjectImage.level9);
        }
    }
}
