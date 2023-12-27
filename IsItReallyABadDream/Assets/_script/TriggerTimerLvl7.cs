using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTimerLvl7 : MonoBehaviour
{
    public bool mulaiTimerLvl7;
    private bool sdhTrigger = false;
    public dialog mulaiLevel7;
    public string notifasiWaktuHabis;
    public bool WaktuHabis;
    public VectorValue playerMemoryi;

    // Start is called before the first frame update
    void Start()
    {
        if(triggerSleseLevel6.level7 && !sdhTrigger)
        {
            FindObjectOfType<DialogManager>().StartDialog(mulaiLevel7);
            sdhTrigger=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(sdhTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
        }
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sdhTrigger)
        {
            TimerScript.TimerOn = true;
            mulaiTimerLvl7 = true;
            Debug.Log("harusnya dah mulai");
        }

        if(!TimerScript.TimerOn && mulaiTimerLvl7)
        {
            FindObjectOfType<NotificationManager>().StartNotification(notifasiWaktuHabis);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<NotificationManager>().HideNotification();
                triggerSleseLevel6.level7 = false;
                triggerTidur.level8 = true;
                WaktuHabis = true;
                SceneManager.LoadScene("LabirinNM");
                playerMemoryi.initialValue = new Vector2(-20.0f, 1.24f);
            }
        }
    }
}
