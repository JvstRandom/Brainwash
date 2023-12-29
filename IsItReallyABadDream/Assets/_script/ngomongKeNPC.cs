using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngomongKeNPC : MonoBehaviour
{
    public dialog percakapanNpc;
    public dialog percakapanNgobati;
    public static int jmlhPerkenalan = 0;
    public SpriteRenderer characterSpriteRenderer;

    public static int jmlhNgobati = 0;
    private bool sudahNgomong = false;
    private bool sudahNgomong2 = false;
    private bool isSdhNambah = false;
    private bool isSdhNambah2 = false;
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
            Debug.Log("trigger lvl7 = " + triggerSleseLevel6.level7);
            Debug.Log("sdhngomong2 = " + sudahNgomong2);
            if (SceneT4Bermain1.sceneMulai && MainMenu.level1 && !sudahNgomong)
            {
                FindObjectOfType<DialogManager>().StartDialog(percakapanNpc);
                sudahNgomong = true;
            }
            if (triggerSleseLevel6.level7 && !sudahNgomong2)
            {
                Debug.Log("halooooooooo");
                FindObjectOfType<DialogManager>().StartDialog(percakapanNgobati);
                sudahNgomong2 = true;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("trigger lvl7 = " + triggerSleseLevel6.level7);
        Debug.Log("sdhngomong2 = " + sudahNgomong2);
        if (Input.GetKeyDown(KeyCode.Space) && (sudahNgomong || sudahNgomong2))
        {
            // if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen")){
            //     FindObjectOfType<DialogManager>().DisplayNextSentences();
            // }
            FindObjectOfType<DialogManager>().DisplayNextSentences();

        }
        if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && (sudahNgomong || sudahNgomong2) && (!isSdhNambah && !isSdhNambah2))
        {

            if (MainMenu.level1)
            {
                jmlhPerkenalan++;
                isSdhNambah = true;
                sudahNgomong = false;
            }
            if (triggerSleseLevel6.level7)
            {
                jmlhNgobati++;
                isSdhNambah2 = true;
                sudahNgomong2 = false;
            }
        }
        if (jmlhNgobati == 5)
        {
            FindObjectOfType<NotificationManager>().StartNotification("segera kemabali ke kamar dan tidur sebelum suster notice");
            sdhLevel7 = true;
            
            
        }


        if (MainMenu.level1 && SceneT4Bermain1.sceneMulai)
        {
            characterSpriteRenderer.enabled = true;
        }

        if (jmlhPerkenalan == 5)
        {
            DialogManager.sdhdialog = false;
        }
    }
    void HideNotif()
    {
        Debug.Log("sdh ketutup harusnya");
        FindObjectOfType<NotificationManager>().HideNotification();
    }

}





