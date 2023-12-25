using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;

    public functionalityType tipeFungsi = new functionalityType();

    public bool imageaktif = false;

    public void UseItem()
    {
        if(tipeFungsi == functionalityType.heal)
        {
            healthSystem.Healed(1);
        }
        // if(tipeFungsi == functionalityType.map)
        // {
        //     GameObject.Find("Frey").GetComponent<PlayerManager>().BukaMap();
        // }
        if(tipeFungsi == functionalityType.key)
        {
            GameObject.Find("Frey").GetComponent<PlayerManager>().PickUpKey();
        }
        // if(tipeFungsi == functionalityType.batre)
        // {
        //     PlayerManager.haveBattery = true;
        //     GameObject.Find("Frey").GetComponent<PlayerManager>().NambahDayaLampu();
        // }
    }

    public enum functionalityType
    {
        craft,
        map,
        heal,
        batre,
        key,

    }
}
