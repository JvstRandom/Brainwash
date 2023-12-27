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
    public dialog percakapan5;
    public dialog percakapan7;
    private bool ngomong=false;
    private bool ngomong5=false;
    private bool ngomong7=false;

    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
            if(MainMenu.level1 && !ngomong)
            {
                StartDialog();
                ngomong=true;
            }else if(bukuZach.level5 && !ngomong5)
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapan5);
                ngomong5=true;
            } else if(triggerSleseLevel6.level7 && !ngomong7)
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapan7);
                ngomong7=true;
            }
            
        // Start the dialog when the scene starts
        
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
