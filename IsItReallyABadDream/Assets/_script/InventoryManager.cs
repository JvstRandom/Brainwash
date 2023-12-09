using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuAktif;
    public itemSlot[] ItemSlot;

    public ItemSO[] itemSOs;

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

    public void AddItem(GameObject item)
    {
        for (int i = 0; i < ItemSlot.Length; i++)
        {
            if(ItemSlot[i].isFull == false)
            {
                ItemSlot[i].AddItem(item);
                
                return; //stop the loop
            }
        }
    }

    // public int AddItem(GameObject item)
    // {
    //     for (int i = 0; i < ItemSlot.Length; i++)
    //     {
    //         if(ItemSlot[i].isFull == false && ItemSlot[i].itemName == itemName || ItemSlot[i].quantity == 0)
    //         {
    //             int leftOverItems = ItemSlot[i].AddItem(item);
    //             if(leftOverItems>0){

    //                 return leftOverItems; //stop the loop
    //             }
    //         }
    //     }
    // }

    public void DeselectAllSlot()
    {
        for(int i = 0; i <  ItemSlot.Length; i++)
        {
            ItemSlot[i].Selected.SetActive(false);
            ItemSlot[i].isSelected = false;
        }
    }
}
