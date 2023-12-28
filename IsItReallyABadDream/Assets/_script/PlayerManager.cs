using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject maplabirin;
    public static bool haveKey = false;
    public static bool haveKeyLabirin = false;
    public static bool haveBattery = false;
    public static bool haveMapLabirin = false;
    public static bool havePotion = false;
    public static bool haveCostume;
    public AnimatorOverrideController pakeKostum;
    public bool mapOpen = false;
    // public static LightController lightController;

    public void Start()
    {
        maplabirin.SetActive(false);

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            BukaMap();
        }

        if (haveCostume)
        {
            GetComponent<Animator>().runtimeAnimatorController = pakeKostum as RuntimeAnimatorController;
        }
    }

    public void PickUpKey()
    {

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
        if (haveMapLabirin && !mapOpen)
        {
            maplabirin.SetActive(true);
            mapOpen = true;
        }
        else
        {
            maplabirin.SetActive(false);
            mapOpen = false;
        }
    }

    public void Kostum()
    {

    }


}

