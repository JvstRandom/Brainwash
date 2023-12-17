using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public Light2D light2D;
    public bool lampunyala;
    public Image LightBatteryBar;

    // Battery settings
    public float maxBatteryEnergy = 100f;
    public float currentBatteryEnergy;

    // Energy consumption rate
    public float energyConsumptionRate = 5f;

    void Start()
    {
        light2D = GetComponent<Light2D>();

        light2D.intensity = 0.3f;
        light2D.pointLightOuterRadius = 2f;
        lampunyala = false;
        currentBatteryEnergy = maxBatteryEnergy;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            ToggleLight();
        }

        if (lampunyala && currentBatteryEnergy <= 0)
        {
            light2D.intensity = 0.3f;
            light2D.pointLightOuterRadius = 2f;
            lampunyala = false;
        }

        if (lampunyala && currentBatteryEnergy > 0)
        {
            // Drain battery energy
            currentBatteryEnergy -= energyConsumptionRate * Time.deltaTime;

            float normalizedEnergy = currentBatteryEnergy / maxBatteryEnergy;
            LightBatteryBar.fillAmount = normalizedEnergy;
        }

    }

    void ToggleLight()
    {
        // light2D.enabled = !light2D.enabled;

        if (!lampunyala)
        {
            light2D.intensity = 1.0f;
            light2D.pointLightOuterRadius = 5f;
            lampunyala = true;
        }
        else
        {
            light2D.intensity = 0.3f;
            light2D.pointLightOuterRadius = 2f;
            lampunyala = false;
        }

    }

    public void setBattery()
    {
        currentBatteryEnergy = maxBatteryEnergy;
    }
}
