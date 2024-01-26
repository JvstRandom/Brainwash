using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogTrigger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public static bool isZachDialog1End = false;
    public dialog percakapan;
    private bool sudahhh;
    public GameObject dialohhhh;
    public GameObject zachh;
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
                if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
                {
                    Debug.Log("dadada");
                    dialohhhh.SetActive(false);
                    isDialogActive = false;
                    Destroy(dialohhhh);
                    spriteRenderer.enabled = false;
                }
            }

            // if(MainMenu.level1)
            // {
            //     zachh.SetActive(true);
            // } else {
            //     Destroy(zachh);
            //     zachh.SetActive(false);
            // }

            // if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            // {
            //     Debug.Log("dadada");
            //     Destroy(orang);
            //     orang.SetActive(false);
            //     isDialogActive = false;
            // }

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

        if (collision.CompareTag("Player"))
        {
            if (MainMenu.level1 && !isZachDialog1End && MainMenu.level1 && !faithnhopeCutsceneTrigger.FaithnHopeHilang
            && !sudahhh && !SceneT4Bermain1.sceneMulai && ngomongKeNPC.jmlhPerkenalan != 5)
            {
                Debug.Log("kita disini");
                TriggerDialog();
                spriteRenderer.enabled = true;
            }
            sudahhh = true;
        }
    }
}