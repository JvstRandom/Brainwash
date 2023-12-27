using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectManager : MonoBehaviour
{
    public GameObject suster;
    public GameObject monsterNM;
    public GameObject monsterNM1;
    public GameObject monsterNM2;
    public GameObject monsterNM3;
    // Start is called before the first frame update
    void Start()
    {
        suster.SetActive(false);
        if(triggerdikejar.dikejar)
        {
           suster.SetActive(true); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
