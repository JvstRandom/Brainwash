using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int keyCount;
    public int key;
    public static bool haveKey = false;
    public static bool haveBattery = false;

    public static LightController lightController;

    public void PickUpKey()
    {
        keyCount++;
        haveKey = true;
    }

    public void NambahDayaLampu()
    {
        if(haveBattery)
        {
           lightController.setBattery();
        }
    }


}
