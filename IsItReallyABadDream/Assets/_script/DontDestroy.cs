using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static GameObject[] persistentObjects = new GameObject[3];
    public int ObjectIndex;
    // Start is called before the first frame update
    void Awake()
    {
        if(persistentObjects[ObjectIndex]==null) //akan mengecek spesifik entry di array kita apakah ada di arrray gameonjectnya
        {
            persistentObjects[ObjectIndex] = gameObject;// kalau misal gameobject player blm ada berari ditambah ke array
            DontDestroyOnLoad(gameObject);
        } else if (persistentObjects[ObjectIndex] != null)
        {
            Destroy(gameObject);
        }
    }

}
