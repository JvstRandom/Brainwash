using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuAktif;
    public itemSlot[] ItemSlot;

    public ItemSO[] itemSOs;

    private itemSlot slotitem;

    public Sprite kostumImg;
    public Sprite alatImg;

    public static bool isclick = false;

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

    public void click()
    {
        isclick = true;
    }

    public void useitem(string namaitem)
    {
        for(int i = 0; i < itemSOs.Length; i++)
        {
            if(itemSOs[i].itemName == namaitem)
            {
                itemSOs[i].UseItem();
            }
        }
    }

    public void CraftItem()
    {
        // Check if the crafted item is "costume" and if the required items ("blanket" and "marker") are in the inventory
        if (CheckCraftingRequirements("selimut", "spidol"))
        {
            // Remove the required items from the inventory
            RemoveItemFromInventory("selimut");
            RemoveItemFromInventory("spidol");

            // Add the crafted item to the inventory
            AddItemToInventory("kostum");
        } else if(CheckCraftingRequirements("walkieTalkie", "isolasi", "benang"))
        {
            RemoveItemFromInventory("walkieTalkie");
            RemoveItemFromInventory("isolasi");
            RemoveItemFromInventory("benang");

            AddItemToInventory("alatPendengar");
        }
        else
        {
            Debug.Log("Not enough materials to craft any item.");
        }
    }

    private bool CheckCraftingRequirements(params string[] requiredItems)
    {
        foreach (string item in requiredItems)
        {
            bool itemFound = false;
            for (int i = 0; i < ItemSlot.Length; i++)
            {
                if (ItemSlot[i].itemName == item)
                {
                    itemFound = true;
                    break;
                }
            }
            if (!itemFound)
            {
                return false;
            }
        }
        return true;
    }

    private void AddItemToInventory(string itemName)
    {
        for (int i = 0; i < ItemSlot.Length; i++)
        {
            if (!ItemSlot[i].isFull)
            {
                if(itemName == "kostum")
                {
                    ItemSlot[i].updatedisplay(itemName, "kamu dapat menggunakannya untuk mengelabui monster labirin dengan menyerupainya", kostumImg);
                }else if(itemName == "alatPendengar")
                {
                    ItemSlot[i].updatedisplay(itemName, "dapat digunakan untuk mendengar percakapan di lain ruangan", alatImg);
                }
                break;
            }
        }
    }

    private void RemoveItemFromInventory(string itemName)
    {
        for (int i = 0; i < ItemSlot.Length; i++)
        {
            if (ItemSlot[i].itemName == itemName)
            {
                ItemSlot[i].quantity--; // Decrease quantity of the item
                if (ItemSlot[i].quantity <= 0)
                {
                    ItemSlot[i].isFull = false;
                    ItemSlot[i].EmptySlot();
                }
                // Update inventory UI
                // UpdateInventoryDisplay();
                break;
            }
        }
    }

    public void DeselectAllSlot()
    {
        for(int i = 0; i <  ItemSlot.Length; i++)
        {
            ItemSlot[i].Selected.SetActive(false);
            ItemSlot[i].isSelected = false;
        }
    }
}
