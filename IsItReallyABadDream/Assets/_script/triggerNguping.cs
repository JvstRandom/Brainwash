using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerNguping : MonoBehaviour
{
    // BUAT DIALOG
    public dialog nguping;
    private bool sdhdenger;
    public GameObject dialoggbox;
    public Text choicetxtA;
    public Text choicetxtB;

    // BUAT NGATUR BOOL
    public static bool sceneEavesdrop;
    private bool isDialogActive = false;
    public static bool buatAlatPendengar;
    private static bool sdhmemilih=false;

    // BUAT NGATUR CHOICE
    // public Button optionAButton;
    // public Button optionBButton;
    // private int selectedChoice = -1; // -1 represents no choice selected yet

    private void Start()
    {
        dialoggbox.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDialogActive)
        {
            if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    FindObjectOfType<DialogManager>().DisplayNextSentences();
                    if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
                    {
                        Debug.Log("dadadahhhh");
                        isDialogActive = false;
                        dialoggbox.SetActive(true);
                        choicetxtA.text = "A. Lanjut Mencari tahu Faith and Hope";
                        choicetxtB.text = "B. Membuat alat Pendengar";
                    }
                }
                
            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang && FollowerTrigger.ZachisFollowing
            && !isDialogActive && !sdhmemilih)
            {
                Debug.Log("sudah memenuhi");
                sceneEavesdrop = true;
                FindObjectOfType<DialogManager>().StartDialog(nguping);
                isDialogActive = true;
                // Show notification UI or any other UI indication that the player can interact
            }
        }
    }

    public void HandleChoice(string choice)
    {
        switch (choice)
        {
            case "lanjut":
                buatAlatPendengar = false;
                sdhmemilih=true;
                Debug.Log("Pressed A - Status: " + buatAlatPendengar);
                dialoggbox.SetActive(false);
                break;
            case "buat":
                buatAlatPendengar = true;
                Debug.Log("Pressed B - Status: " + buatAlatPendengar);
                dialoggbox.SetActive(false);
                sdhmemilih=true;
                break;
            default:
            
                break;
        }
    }

}

