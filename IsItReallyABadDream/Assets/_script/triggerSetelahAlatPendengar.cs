using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSetelahAlatPendengar : MonoBehaviour
{
    public dialog ngupingsuster;
    public static bool sdhNguping=false;
    private bool isDialogActives;
    public string notifikasi1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDialogActives && FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
        {
            Debug.Log("memenuhi2");
            FindObjectOfType<DialogManager>().DisplayNextSentences();
        }
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
        {
            sdhNguping = true;
            Debug.Log("status sdh nguping =" + sdhNguping);
            triggerNguping.sceneEavesdrop = false;
        }
        if(Input.GetKeyDown(KeyCode.Space) && FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen")){
            FindObjectOfType<NotificationManager>().HideNotification();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("yyty");
            if (MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang && FollowerTrigger.ZachisFollowing
            && !isDialogActives && triggerNguping.buatAlatPendengar)
            {
                if(InventoryManager.haveAlatPendengar)
                {
                    Debug.Log("sudah memenuhi");
                    FindObjectOfType<DialogManager>().StartDialog(ngupingsuster);
                    isDialogActives = true;
                } else {
                    FindObjectOfType<NotificationManager>().StartNotification(notifikasi1);
                }
            }
        }
    }
}
