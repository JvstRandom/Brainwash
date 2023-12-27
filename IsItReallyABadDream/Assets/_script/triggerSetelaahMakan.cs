using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class triggerSetelaahMakan : MonoBehaviour
{
    public dialog milihHbsMakan;
    private bool ngomong=false;
    public GameObject dialogChoicebox;
    public Text choicetxtA;
    public Text choicetxtB;
    public string notifWarn;
    public string SceneEnding1;
    public static bool ending1 = false;
    public static bool milihending1 = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogChoicebox.SetActive(false);
        if(changeCutsceneMakan.cutsceneMakan && !ngomong && triggerTidur.level4 && !milihending1)
        {
            FindObjectOfType<DialogManager>().StartDialog(milihHbsMakan);
            ngomong=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
            if(FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen"))
            {
                FindObjectOfType<NotificationManager>().HideNotification();
            }
        } 
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
        {
            Debug.Log("sdh slese");
            dialogChoicebox.SetActive(true);
            choicetxtA.text = "A. Lanjut Makan";
            choicetxtB.text = "B. Escape dari dapur ini";
        }
    }

    public void HandlePilihan(string choice)
    {
        switch (choice)
        {
            case "Makan":
                ending1=true;
                SceneManager.LoadScene(SceneEnding1);
                Debug.Log("Pressed A - Status ending: " + ending1);
                dialogChoicebox.SetActive(false);
                milihending1=true;
                break;
            case "keluar dari dapur":
                ending1=false;
                FindObjectOfType<NotificationManager>().StartNotification(notifWarn);
                Debug.Log("Pressed A - Status ending: " + ending1);
                dialogChoicebox.SetActive(false);
                milihending1=true;
                break;
            default:
                break;
        }
    }
}
