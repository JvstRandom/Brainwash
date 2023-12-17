using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Image imageMuncul;
    public Sprite Imagebetul;
    public functionalityType tipeFungsi = new functionalityType();

    public bool imageaktif = false;

    public void UseItem()
    {
        if(tipeFungsi == functionalityType.heal)
        {
            GameObject.Find("Frey").GetComponent<healthSystem>().Healed(1);
        }
        if(tipeFungsi == functionalityType.imageDuar)
        {
            imageMuncul.sprite = Imagebetul;
             if(!imageaktif)
            {
                imageMuncul.enabled = true;
                imageaktif = true;
            } else if (imageaktif){
                imageMuncul.enabled = false;
                imageaktif = false;
            }
        }
        if(tipeFungsi == functionalityType.key)
        {
            GameObject.Find("Frey").GetComponent<PlayerManager>().PickUpKey();
        }
        if(tipeFungsi == functionalityType.batre)
        {
            PlayerManager.haveBattery = true;
            GameObject.Find("Frey").GetComponent<PlayerManager>().NambahDayaLampu();
        }
    }

    public enum functionalityType
    {
        craft,
        imageDuar,
        heal,
        batre,
        key,

    }
}
