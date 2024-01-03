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
    public dialog percakapan9;
    private bool ngomong=false;
    private bool ngomong5=false;
    private bool ngomong7=false;
    private bool ngomong9=false;

    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
            
            
        // Start the dialog when the scene starts
        
    }

    // Method to start the dialog
    void StartDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(percakapan1);
    }

    // Update is called once per frame
    void Update()
    {
        if(MainMenu.level1 && !ngomong && !SceneT4Bermain1.sceneMulai)
            {
                StartDialog();
                ngomong=true;
            }else if(bukuZach.level5 && !ngomong5 && PlayerManager.haveKey)
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapan5);
                ngomong5=true;
            } else if(triggerSleseLevel6.level7 && !ngomong7 && !PlayerManager.havePotion)
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapan7);
                ngomong7=true;
            } else if(ObjectImage.level9 && !ngomong9 )
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapan9);
                ngomong9=true;
            }
            
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
