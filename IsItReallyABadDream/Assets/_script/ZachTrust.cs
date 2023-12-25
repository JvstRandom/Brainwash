using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZachTrust : MonoBehaviour
{
    public static Image Zachtrust;
    public static float TotalTrust;

    // Start is called before the first frame update
    void Start()
    {
        TotalTrust = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if kondisi zach naik jadi nanti dipanggil sesui if banyak
        if(triggerSetelahAlatPendengar.sdhNguping)
        {
            AddTrust(20);
        }
    }

    public static void AddTrust(float amount)
    {
        TotalTrust += amount;
        Zachtrust.fillAmount = TotalTrust / 100f;
    }
}
