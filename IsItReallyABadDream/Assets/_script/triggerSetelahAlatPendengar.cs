using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSetelahAlatPendengar : MonoBehaviour
{
    public dialog ngupingsuster;
    public static bool sdhNguping;
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

            FindObjectOfType<DialogManager>().DisplayNextSentences();
            if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                sdhNguping = true;

                triggerNguping.sceneEavesdrop = false;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen"))
        {
            FindObjectOfType<NotificationManager>().HideNotification();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("yyty");
            if (MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang && FollowerTrigger.ZachisFollowing
            && !isDialogActives && triggerNguping.buatAlatPendengar && !triggerPercakapandokter.sdhlvl1)
            {
                if (InventoryManager.haveAlatPendengar)
                {
                    Debug.Log("sudah memenuhi");
                    FindObjectOfType<DialogManager>().StartDialog(ngupingsuster);
                    isDialogActives = true;
                }
                else
                {
                    FindObjectOfType<NotificationManager>().StartNotification(notifikasi1);
                }
            }
        }
    }
}
