using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPercakapandokter : MonoBehaviour
{
    public dialog dialogdokterdiRR;
    private bool lagiDialog = false;
    // private bool laginotif = false;
    public string notifikasiSusterDateng;
    public static bool sdhlvl1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && lagiDialog)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
        }
        if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && lagiDialog)
        {
            FindObjectOfType<NotificationManager>().StartNotification(notifikasiSusterDateng);
            // laginotif = true;
            triggerNguping.buatAlatPendengar = false;
            faithnhopeCutsceneTrigger.FaithnHopeHilang = false;
            sdhlvl1 = true;
            Debug.Log("status faith hilang = " + faithnhopeCutsceneTrigger.FaithnHopeHilang);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("yyty");
            if (MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang && FollowerTrigger.ZachisFollowing && !lagiDialog)
            {

                Debug.Log("sudah memenuhi");
                FindObjectOfType<DialogManager>().StartDialog(dialogdokterdiRR);
                lagiDialog = true;

            }
        }
    }
}
