using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogLevel7 : MonoBehaviour
{
    public dialog dialogDay4;
    private bool sdhdialonglvl7 = false;
    private bool lagingomomng=true;

    // Start is called before the first frame update
    void Start()
    {
        if(triggerSleseLevel6.level7 && !sdhdialonglvl7)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialogDay4);
            sdhdialonglvl7 = true;
            lagingomomng = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && lagingomomng && triggerSleseLevel6.level7)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
        }
    }
}
