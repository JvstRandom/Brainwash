using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoglvl2 : MonoBehaviour
{
    public dialog dialogNM1;
    private bool sdhdialonglvl2 = false;
    private bool lagingomomng = false;
    // Start is called before the first frame update
    void Start()
    {
        if (triggerTidur.level2 && !sdhdialonglvl2)
        {
            FindObjectOfType<DialogManager>().StartDialog(dialogNM1);
            sdhdialonglvl2 = true;
            lagingomomng = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && lagingomomng && triggerTidur.level2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
        }
    }
}
