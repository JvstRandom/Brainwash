using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class itemSlot : MonoBehaviour, IPointerClickHandler
{
    // ITEM DATA
    public string itemName;
    public int quantity;
    public Sprite spriteItem;
    public bool isFull;
    public string itemDesc;
    public Sprite emptySprite;

    //ITEM SLOT
    [SerializeField]
    private TMP_Text quantityTxt;

    [SerializeField]
    private Image itemImage;

    //ITEM DESCRIPTION 
    public Image itemDescImage;
    public TMP_Text itemDescName;
    public TMP_Text itemDescText;

    public GameObject Selected;
    public bool isSelected;

    private InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
    }

    public void AddItem(GameObject item){
        items ScriptItem = item.GetComponent<items>();
        
        if(ScriptItem != null){
            this.itemName = ScriptItem.i_Name;
            this.quantity = ScriptItem.i_quantity;
            this.spriteItem = ScriptItem.i_sprite;
            this.itemDesc = ScriptItem.i_Desc;
            isFull = true;
            Debug.Log("itemName: " + itemName + "itemQuantity: " + quantity + "itemSprite: " + spriteItem + " " + itemDesc);

            quantityTxt.text = quantity.ToString();
            quantityTxt.enabled = true;
            itemImage.sprite = spriteItem;
            itemImage.enabled = true;
        } else {
            Debug.Log("GameObject Item script not found");
        }

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            OnLeftClick();
        }
        if(eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick();
        }
    }

    public void OnLeftClick()
    {
        inventoryManager.DeselectAllSlot();
        Selected.SetActive(true);
        isSelected = true;
        itemDescName.text = itemName;
        itemDescText.text = itemDesc;
        itemDescImage.sprite = spriteItem;
        if(itemDescImage.sprite == null){
            itemDescImage.sprite = emptySprite;
        }
    }

    public void OnRightClick()
    {

    }
}
