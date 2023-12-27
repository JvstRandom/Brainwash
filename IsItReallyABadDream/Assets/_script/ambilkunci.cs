using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambilkunci : MonoBehaviour
{
    public string notifkey;
    private bool sdhmuncul=false;
    private bool dalamrange=false;
    public static bool playersudahambil=false;
    public bool sudahTimer=false;

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
                playersudahambil=true;
            } else if(!sudahTimer){
                TimerScript.TimerOn=true;
                FindObjectOfType<NotificationManager>().HideNotification();
                if(!TimerScript.TimerOn){
                    sudahTimer = true;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            dalamrange=true;
        }
    }
    
}
