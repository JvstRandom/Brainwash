using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;


    public enum functionalityType
    {
        craft,
        imageDuar,
        cmnmencet
    }
}
