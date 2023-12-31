using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogTrigger : MonoBehaviour
{
    public static bool isZachDialog1End = false;
    public dialog percakapan;
    public GameObject orang;
    private bool sudahhh;
    public GameObject dialohhhh;
    private bool isDialogActive = false; // Track if the dialog is active

    void Update()
    {
        // Check if the dialog is active and space is pressed to advance
        if (isDialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            // Display the next sentences in the dialog
            if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    FindObjectOfType<DialogManager>().DisplayNextSentences();
                    isZachDialog1End = true;
                    Debug.Log("status" + isZachDialog1End);
                }
                if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                Debug.Log("dadada");
                Destroy(dialohhhh);
                orang.SetActive(false);
                isDialogActive = false;
            }
            }

            if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                Debug.Log("dadada");
                Destroy(orang);
                orang.SetActive(false);
                isDialogActive = false;
            }

            // Check if the dialog has ended
            // if (DialogManager.sdhdialog)
            // {
            //     // Dialog is finished, reset variables and flags
            //     isDialogActive = false;
            //     isZachDialog1End = false;
            // }
        }
    }

    public void TriggerDialog()
    {
        // Start the dialog when triggered
        FindObjectOfType<DialogManager>().StartDialog(percakapan);
        isDialogActive = true; // Set the flag to indicate the dialog is active
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player") && MainMenu.level1 && !faithnhopeCutsceneTrigger.FaithnHopeHilang && !sudahhh)
        {
            if(MainMenu.level1 && !isZachDialog1End){
                TriggerDialog();
            }
            sudahhh=true;
        }
    }
}
