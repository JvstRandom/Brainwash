using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PintuLabirin : MonoBehaviour
{
    public Animator anim;
    public GameObject SceneTrans;
    private bool isInRange=false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        SceneTrans.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.E))
        {
            if(PlayerManager.haveKeyLabirin)
            {
                anim.SetBool("IsBuka", true);
                SceneTrans.SetActive(true);
            } else {
                FindObjectOfType<NotificationManager>().StartNotification("anda belum mempunyai kunci");
                anim.SetBool("IsBuka", false);
                Debug.Log("status " + FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen"));
                if(FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen"))
                {
                    Invoke("HideNotif", 2f);
                }
            }  
        }
    }

    void HideNotif()
    {
        Debug.Log("sdh ketutup harusnya");
        FindObjectOfType<NotificationManager>().HideNotification();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
