using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogLevel1 : MonoBehaviour
{
    // INSTRUKSI
    public Text instruksi;
    public GameObject intruksiBox;
    public string instruksiIsi;
    // private bool instructionDisplayed = false;
    public dialog percakapan1;

    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        intruksiBox.SetActive(true);
        instruksi.text = instruksiIsi;

        // Start the dialog when the scene starts
        if(MainMenu.level1)
        {
            StartDialog();
        }
    }

    // Method to start the dialog
    void StartDialog()
    {
        // instructionDisplayed = true; // Set the instruction displayed to true
        intruksiBox.SetActive(false); // Hide instruction box
        FindObjectOfType<DialogManager>().StartDialog(percakapan1);
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenu.level1 && !faithnhopeCutsceneTrigger.FaithnHopeHilang)
        {
            // Check if the dialog is still active in the DialogManager
            if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    FindObjectOfType<DialogManager>().DisplayNextSentences();
                }
            }
        }
    }
}
