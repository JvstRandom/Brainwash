using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerPapan : MonoBehaviour
{
    public GameObject tempatGambar;
    public Image t4nya;
    public Sprite GambarPapan;
    public dialog dialogpapan;
    private bool sdhGambar=false;
    public static bool sdhLevel6 = false;
    // Start is called before the first frame update
    void Start()
    {
        tempatGambar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(sdhGambar && Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<DialogManager>().StartDialog(dialogpapan);
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
            else if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                changeAppereance();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && triggerTidur.level6)
        {
            tempatGambar.SetActive(true);
            t4nya.sprite = GambarPapan;
            sdhGambar = true;
        }
    }

    void changeAppereance()
    {
        tempatGambar.SetActive(false);
        sdhLevel6 = true;
    }
}
