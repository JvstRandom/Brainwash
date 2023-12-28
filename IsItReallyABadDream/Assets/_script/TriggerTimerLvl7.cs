using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTimerLvl7 : MonoBehaviour
{
    public GameObject timerkack;
    public bool mulaiTimerLvl7;
    private bool sdhTrigger = false;
    public dialog mulaiLevel7;
    public string notifasiWaktuHabis;
    public bool WaktuHabis;
    public VectorValue playerMemoryi;

    // Start is called before the first frame update
    void Start()
    {
        timerkack.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (sdhTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            if (FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }
        }
        if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sdhTrigger)
        {
            timerkack.SetActive(true);
            TimerScript.TimerOn = true;
            mulaiTimerLvl7 = true;
            Debug.Log("harusnya dah mulai timer = " + TimerScript.TimerOn);
        }

        if (TimerScript.sudahTimer && mulaiTimerLvl7)
        {
            FindObjectOfType<NotificationManager>().StartNotification(notifasiWaktuHabis);
            if (Input.GetKeyDown(KeyCode.Space))
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (triggerSleseLevel6.level7 && !sdhTrigger)
            {
                Debug.Log("trigger timer level 7");
                PlayerManager.haveKey = true;
                FindObjectOfType<DialogManager>().StartDialog(mulaiLevel7);
                sdhTrigger = true;
            }
        }
    }
}
