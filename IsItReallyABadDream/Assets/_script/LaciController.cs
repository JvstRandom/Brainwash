using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaciController : MonoBehaviour
{
    private bool IsOpen;
    public Animator animator;

    public List<GameObject> itemsToCollect = new List<GameObject>();

    private bool isItemCollected = false;
    public Text buatnotif;
    public GameObject t4notif;

    private InventoryManager inventoryManager;

    public AudioClip bukaLaci;
    public AudioClip nutupLaci;
    public AudioClip dapatBarang;
    private bool sdhnotif = false;

    public AudioSource audioSource;

    void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
        audioSource = GetComponent<AudioSource>();
        t4notif.SetActive(false);
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
            buatnotif.text = "";
            t4notif.SetActive(false);
        }
    }

    public void ItemPicked()
    {
        if(itemsToCollect.Count == 0 && !sdhnotif)
        {
            ShowEmptyNotification();
            sdhnotif = true;
        } 
        else if(!isItemCollected && itemsToCollect.Count > 0)
        {
            int randomIndex = Random.Range(0, itemsToCollect.Count);
            GameObject randomItem = itemsToCollect[randomIndex];
            Debug.Log("ItemPicked: " + randomItem);
            Debug.Log(randomIndex);
            inventoryManager.AddItem(randomItem);

            randomItem.SetActive(false);
            itemsToCollect.RemoveAt(randomIndex);
            isItemCollected = true;
            
                string notif = "anda sudah mengambil sesuatu";
                buatnotif.text = notif;
                t4notif.SetActive(true);
                Debug.Log("mantab");
                sdhnotif = true;
                audioSource.clip = dapatBarang;
                audioSource.Play();
        }

        // if(sdhnotif)
        // {
        //     t4notif.SetActive(false);
        // }
    }

    void ShowEmptyNotification()
    {
        buatnotif.text = "tidak ada item untuk diambil disini";
        t4notif.SetActive(true);
    }
}
