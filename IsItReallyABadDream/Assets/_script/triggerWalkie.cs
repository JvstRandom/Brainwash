using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerWalkie : MonoBehaviour
{
    public GameObject walkietalkie;
    public dialog walkitalkiedialog;
    public string notifikasi;
    private bool sdhnemu = false;
    private InventoryManager inventoryManager;
    public AudioSource audioSource;
    private bool sdhambil = false;
    public GameObject walkie;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("Inventory").GetComponent<InventoryManager>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sdhnemu)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
                Debug.Log("hahaahaha");
            }
        }
        if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sdhnemu && !sdhambil)
        {
            Debug.Log("sudah");
            FindObjectOfType<NotificationManager>().StartNotification(notifikasi);
            
            if (Input.GetKeyDown(KeyCode.C)) // Check if dialog box is active and 'C' is pressed
            {
                inventoryManager.AddItem(walkietalkie);
                // FindObjectOfType<InventoryManager>().AddItem(walkietalkie);
                audioSource.Play();
                FindObjectOfType<NotificationManager>().HideNotification();
                sdhambil = true;
                Destroy(walkie);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !sdhnemu)
        {
            Debug.Log("huhueg");
            if (triggerNguping.buatAlatPendengar && MainMenu.level1)
            {
                Debug.Log("huha");
                FindObjectOfType<DialogManager>().StartDialog(walkitalkiedialog);
                sdhnemu=true;
            }
        }
    }

}
