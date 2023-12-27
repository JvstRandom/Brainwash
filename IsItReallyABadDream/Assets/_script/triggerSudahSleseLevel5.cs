using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSudahSleseLevel5 : MonoBehaviour
{
    public dialog LolosSuster;
    public string notifSleseLevel5;
    public string notifBlmSleseLevel5;
    public static bool sdhlvl5=false;
    private bool sdhnotif=false;
    private bool dialog=false;
    public GameObject SceneTransition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!TimerScript.TimerOn && !dialog)
        {
            FindObjectOfType<DialogManager>().StartDialog(LolosSuster);
            dialog = true;
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && dialog)
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
        }
        if(sdhnotif && Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<NotificationManager>().HideNotification();
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && bukuZach.level5)
        {
            if(PlayerManager.haveKey && SpriteChanger.sdhlihatKipas)
            {
                FindObjectOfType<NotificationManager>().StartNotification(notifSleseLevel5);
                SceneTransition.SetActive(true);
                bukuZach.level5 = false;
                sdhlvl5 = true;
            } else {
                FindObjectOfType<NotificationManager>().StartNotification(notifBlmSleseLevel5);
                SceneTransition.SetActive(false);
                sdhnotif=true;
            }
        }
    }
}
