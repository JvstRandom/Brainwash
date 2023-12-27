using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogLevel5 : MonoBehaviour
{
    public dialog percakapan5;
    private bool sdhngomong;
    // Start is called before the first frame update
    void Start()
    {
        if(bukuZach.level5 & !sdhngomong)
        {
            FindObjectOfType<DialogManager>().StartDialog(percakapan5);
            sdhngomong = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(bukuZach.level5 && sdhngomong)
        {
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
