using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int keyCount;
    public int key;
    public GameObject maplabirin;
    public ItemSO[] itemSOs;
    public static bool haveKey = false;
    public static bool haveBattery = false;
    public static bool haveMapLabirin = false;

    public bool mapOpen= false;
    // public static LightController lightController;

    public void Start()
    {
        maplabirin.SetActive(false);
    }



    public void PickUpKey()
    {
        keyCount++;
        haveKey = true;
    }

    // public void NambahDayaLampu()
    // {
    //     if(haveBattery)
    //     {
    //        lightController.setBattery();
    //     }
    // }

    public void BukaMap()
    {
        if(haveMapLabirin && !mapOpen)
        {
            maplabirin.SetActive(true);
            mapOpen = true;
        } else {
            maplabirin.SetActive(false);
            mapOpen = false;
        }
    }


}

