using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuAktif;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory") && !menuAktif)
        {
            Time.timeScale = 0;
            InventoryMenu.SetActive(true);
            menuAktif=true;
        }

        else if (Input.GetButtonDown("Inventory") && menuAktif)
        {
            Time.timeScale = 1;
            InventoryMenu.SetActive(false);
            menuAktif=false;
        }
    }
}
