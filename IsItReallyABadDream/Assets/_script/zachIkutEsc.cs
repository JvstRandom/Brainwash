using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zachIkutEsc : MonoBehaviour
{
    public dialog NgajakZach;
    public static bool sdhNgajak;
    private bool sdhngomong;
    public GameObject dialoggbox;
    public Text choicetxtA;
    public Text choicetxtB;
    private bool sdhmemilih;

    // Start is called before the first frame update
    void Start()
    {
        dialoggbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && sdhngomong)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
        }
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sdhngomong && !sdhmemilih)
        {
            Debug.Log("sdh slese");
            sdhngomong = false;
            dialoggbox.SetActive(true);
            choicetxtA.text = "A. Lanjut Mencari tahu Faith and Hope";
            choicetxtB.text = "B. Membuat alat Pendengar";
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && ObjectImage.level9)
        {
            FindObjectOfType<DialogManager>().StartDialog(NgajakZach);
            sdhngomong = true;
        }
    }

    public void HandlePilihan(string choice)
    {
        switch (choice)
        {
            case "lanjut":
                sdhNgajak = false;
                sdhmemilih=true;
                Debug.Log("Pressed A - Status: " + sdhNgajak);
                dialoggbox.SetActive(false);
                break;
            case "NgajakZach":
                sdhNgajak = true;
                Debug.Log("Pressed B - Status: " + sdhNgajak);
                dialoggbox.SetActive(false);
                sdhmemilih=true;
                break;
            default:
            
                break;
        }
    }
}
