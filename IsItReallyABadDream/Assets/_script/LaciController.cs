using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaciController : MonoBehaviour
{
    private bool IsOpen;
    public Animator animator;

    public List<GameObject> itemsToCollect = new List<GameObject>();

    public bool isItemCollected = false;

    private InventoryManager inventoryManager;

    public AudioClip bukaLaci;
    public AudioClip nutupLaci;

    public AudioSource audioSource;

    void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
        audioSource = GetComponent<AudioSource>();
    }

    public void LaciDibuka()
    {
        if(!IsOpen) 
        {
            audioSource.clip = bukaLaci;
            audioSource.Play();
            IsOpen = true;
            Debug.Log("Laci Dibuka");
            animator.SetBool("isOpen", IsOpen);
            soundControll.PlaySound("openDrawer");
            // if(!isItemCollected){
            //     ItemPicked();
            //     isItemCollected = true;
            // }
        }else
        {
            audioSource.clip = nutupLaci;
            audioSource.Play();
            IsOpen = false;
            animator.SetBool("isOpen", IsOpen);
            soundControll.PlaySound("closeDrawer");
        }
    }

    public void ItemPicked()
    {
        if(!isItemCollected)
        {
            int randomIndex = Random.Range(0, itemsToCollect.Count);
            GameObject randomItem = itemsToCollect[randomIndex];
            Debug.Log("ItemPicked: " + randomItem);
            Debug.Log(randomIndex);
            inventoryManager.AddItem(randomItem);

            randomItem.SetActive(false);
            itemsToCollect.RemoveAt(randomIndex);
            isItemCollected = true;

            // int randomIndex = Random.Range(0, itemsToCollect.Count);
            // GameObject randomItem = itemsToCollect[randomIndex];
            // Debug.Log("ItemPicked: " + randomItem);

            // int leftOverItems = inventoryManager.AddItem(randomItem);
            // items ScriptItems = item.GetComponent<items>();
            // if(leftOverItems <= 0)
            // {
            //     randomItem.SetActive(false);
            //     itemsToCollect.RemoveAt(randomIndex);
            // } else {
            //     if(ScriptItems != null){
            //         ScriptItems.i_quantity = leftOverItems;
            //     } else {
            //         Debug.Log("GameObject Item script not found");
            //     }
            // }
            // isItemCollected = true;
        }
    }
}
