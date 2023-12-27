using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogLvl8 : MonoBehaviour
{
    public dialog percakapanLvl8;
    private bool ngomong;

    // Start is called before the first frame update
    void Start()
    {
        if(triggerTidur.level8 && !ngomong)
        {
            FindObjectOfType<DialogManager>().StartDialog(percakapanLvl8);
            ngomong = true;
        }
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
