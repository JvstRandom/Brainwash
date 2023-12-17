using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZachTrust : MonoBehaviour
{
    public Image Zachtrust;
    public float TotalTrust;

    // Start is called before the first frame update
    void Start()
    {
        TotalTrust = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if kondisi zach naik jadi nanti dipanggil sesui if banyak
        if(Input.GetKeyDown(KeyCode.Z))
        {
            AddTrust(20);
        }
    }

    public void AddTrust(float amount)
    {
        TotalTrust += amount;
        Zachtrust.fillAmount = TotalTrust / 100f;
    }
}
