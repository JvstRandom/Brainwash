using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testlvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Kamu sdh nyentuh");
            triggerTidur.level2 = true;
            Debug.Log("status lvl 2 = " + triggerTidur.level2);
        }
    }
}
