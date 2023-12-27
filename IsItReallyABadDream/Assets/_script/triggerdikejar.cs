using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerdikejar : MonoBehaviour
{
    public static bool dikejar = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && triggerTidur.level4)
        {
            dikejar=true;
        }
    }

}
