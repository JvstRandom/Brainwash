using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int keyCount;
    public int key;

    public void PickUpKey()
    {
        keyCount++;
    }
}
