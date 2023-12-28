using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambilkunci : MonoBehaviour
{
    public string notifkey;
    private bool sdhmuncul=false;
    private bool dalamrange=false;
    public static bool playersudahambil=false;
    public static bool sudahTimer=false;
    public GameObject sustery;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && dalamrange)
        {
            if(!sdhmuncul)
            {
                PlayerManager.haveKey=true;
                Debug.Log("dapet kunci = " + PlayerManager.haveKey);
                FindObjectOfType<NotificationManager>().StartNotification(notifkey);
                sdhmuncul=true;
            } else if(!sudahTimer && sdhmuncul){
                Debug.Log("sudahmati");
                playersudahambil=true;
                TimerScript.TimerOn=true;
                TriggerMulaiSceneRS.mulaiSceneRS = false;
                sustery.SetActive(true);
                Debug.Log("TimerScript = " + TimerScript.TimerOn);
                FindObjectOfType<NotificationManager>().HideNotification();
                // if(!TimerScript.TimerOn)
                // {
                //     sudahTimer = true;
                //     Debug.Log("sudah timer = " + sudahTimer);
                // }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && bukuZach.level5 && !sudahTimer)
        {
            dalamrange=true;
        }
    }
    
}
