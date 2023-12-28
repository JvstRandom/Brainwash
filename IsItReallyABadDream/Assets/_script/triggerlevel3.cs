using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerlevel3 : MonoBehaviour
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
            bendaMemoriNm.level3 = true;
            Debug.Log("status lvl 2 = " + bendaMemoriNm.level3);
        }
    }
}
