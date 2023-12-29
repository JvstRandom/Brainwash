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
    private bool ngomong;
    private bool sdhGambar = false;
    private bool slese;
    public static bool sdhLevel6 = false;
    // Start is called before the first frame update
    void Start()
    {
        tempatGambar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && ngomong && Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
            slese = true;
        }
        if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && slese)
        {
            sdhLevel6 = true;
            Debug.Log("status sdhlvl6 = " + sdhLevel6);
            tempatGambar.SetActive(false);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && triggerTidur.level6)
        {
            tempatGambar.SetActive(true);
            t4nya.sprite = GambarPapan;
            sdhGambar = true;
            FindObjectOfType<DialogManager>().StartDialog(dialogpapan);
            ngomong = true;
        }
    }

    void changeAppereance()
    {
        tempatGambar.SetActive(false);

    }
}
