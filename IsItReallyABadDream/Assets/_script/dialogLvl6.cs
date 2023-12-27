using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogLvl6 : MonoBehaviour
{
    public dialog dialogNM3;
    private bool sdhdialoglvl6;
    private bool lagingomomng = false;

    // Start is called before the first frame update
    void Start()
    {
        if(triggerTidur.level6 && !sdhdialoglvl6)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialogNM3);
            sdhdialoglvl6 = true;
            lagingomomng = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && lagingomomng)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
        }
    }
}
