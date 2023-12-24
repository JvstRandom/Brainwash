using UnityEngine;
using UnityEngine.UI;

public class SceneT4Bermain1 : MonoBehaviour
{
    public dialog percakapanMasukT4Bermain;

    public static bool sceneMulai;
    private bool isDialogActive = false;

    private bool sdhngomong = false;

    void Start()
    {  
        sceneMulai = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDialogActive)
        {
            sdhngomong = true;
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }

            if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                isDialogActive = false;
                
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !sdhngomong && !faithnhopeCutsceneTrigger.FaithnHopeHilang)
        {
            Debug.Log("huhu");
            Debug.Log("jumlah:" + ngomongKeNPC.jmlhPerkenalan);
            if (!sceneMulai && MainMenu.level1)
            {
                Debug.Log("huha");
                sceneMulai = true;
                isDialogActive = true;
                FindObjectOfType<DialogManager>().StartDialog(percakapanMasukT4Bermain);
            }
        }
    }

}
