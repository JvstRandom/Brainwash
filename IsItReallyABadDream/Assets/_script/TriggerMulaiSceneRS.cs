using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMulaiSceneRS : MonoBehaviour
{
    public static bool mulaiSceneRS;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && bukuZach.level5)
        {
            mulaiSceneRS = true;
        }
    }
}
