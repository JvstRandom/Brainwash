using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogWhenInterac : MonoBehaviour
{
    public dialog nyentuhObject;
    private bool sdhlihat = false;
    private bool inrange = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inrange && Input.GetKeyDown(KeyCode.Space) && !sdhlihat)
        {
            FindObjectOfType<DialogManager>().StartDialog(nyentuhObject);
            sdhlihat = true;
            if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sdhlihat)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
                Debug.Log("sudah selesai ngomongnya");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            inrange = true;
        }
    }
}
