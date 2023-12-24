using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggersetelahCutscene1 : MonoBehaviour
{
    public GameObject dialogT4;
    public Text dialogtext;
    public dialog percakapanZ;
    private bool isDialogActive;
    private bool sdhInstruksi = false;
    // Start is called before the first frame update
    void Start()
    {
        isDialogActive =false;
    }

    // Update is called once per frame
    void Update()
    {
        if(faithnhopeCutsceneTrigger.FaithnHopeHilang && !sdhInstruksi)
        {
            dialogT4.SetActive(true);
            dialogtext.text = "Ha? Kenapa Faith dan Hope dibawa secara paksa oleh suster itu? Mungkin aku bisa tanya Zach";
            sdhInstruksi = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isDialogActive)
        { 
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }  
        }
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                Debug.Log("sdh slese");
                isDialogActive = false;
            }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang){
                isDialogActive = true;
                FindObjectOfType<DialogManager>().StartDialog(percakapanZ);
            }
        }
    }
}
