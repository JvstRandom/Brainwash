using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngomongKeNPC : MonoBehaviour
{
    public dialog percakapanNpc;
    public static int jmlhPerkenalan = 0;
    public SpriteRenderer characterSpriteRenderer;

    public static int jmlhNgobati = 0;
    private bool sudahNgomong=false;
    private bool isSdhNambah=false;
    public static bool sdhLevel7;

    void Starts()
    {
        characterSpriteRenderer = GetComponent<SpriteRenderer>();
        if (MainMenu.level1 && SceneT4Bermain1.sceneMulai)
        {
            ShowCharacterSprite();
        }
        else 
        {
            // HideCharacterSprite();
            Debug.Log("disembunyiin");
        }
    }

    public void ShowCharacterSprite()
    {
        characterSpriteRenderer.enabled = true; // Enable the sprite renderer
    }

    public void HideCharacterSprite()
    {
        characterSpriteRenderer.enabled = false; // Disable the sprite renderer
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (SceneT4Bermain1.sceneMulai && MainMenu.level1 && !sudahNgomong)
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapanNpc);
                sudahNgomong = true;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && sudahNgomong)
        {
            // if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen")){
            //     FindObjectOfType<DialogManager>().DisplayNextSentences();
            // }
            FindObjectOfType<DialogManager>().DisplayNextSentences();
            
        }
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && sudahNgomong && !isSdhNambah){
                isSdhNambah= true;
                sudahNgomong = false;
                if(MainMenu.level1)
                {
                    jmlhPerkenalan++;
                }
                if(triggerSleseLevel6.level7)
                {
                    jmlhNgobati++;
                }
            }
        if(jmlhNgobati == 4)
        {
            FindObjectOfType<NotificationManager>().StartNotification("segera kemabali ke kamar dan tidur sebelum suster notice");
            sdhLevel7 = true;
            if(FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen"))
                {
                    Invoke("HideNotif", 2f);
                }
        }


        if (MainMenu.level1 && SceneT4Bermain1.sceneMulai){
             characterSpriteRenderer.enabled = true;
        }

        if(jmlhPerkenalan == 5){
            DialogManager.sdhdialog = false;
        }
    }
    void HideNotif()
    {
        Debug.Log("sdh ketutup harusnya");
        FindObjectOfType<NotificationManager>().HideNotification();
    }

}





