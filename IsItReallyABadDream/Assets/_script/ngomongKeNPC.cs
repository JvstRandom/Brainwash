using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ngomongKeNPC : MonoBehaviour
{
    public Text dialogTexts;
    public string[] dialogs;
    public Text namaCharacter;
    public string[] namaYgNgomong;
    public GameObject dialogBox;

    public Image imageDisplay; // Reference to the Image UI object
    public Sprite[] imageList;

    public static int jmlhPerkenalan = 0;
    private int currentIndex = 0;
    private bool isDialogActive = false;
    public SpriteRenderer characterSpriteRenderer;
    private bool sudahNgomong=false;

    void Starts()
    {
        characterSpriteRenderer = GetComponent<SpriteRenderer>();
        if (MainMenu.level1 && SceneT4Bermain1.sceneMulai)
        {
            ShowCharacterSprite();
        }
        else
        {
            HideCharacterSprite();
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
                StartDialog();
            }
        }
    }

    // Starts the dialog sequence
    void StartDialog()
    {
        dialogBox.SetActive(true);
        isDialogActive = true;
        currentIndex = 0;
        dialogTexts.text = dialogs[currentIndex];
        namaCharacter.text = namaYgNgomong[currentIndex];
        imageDisplay.sprite = imageList[currentIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogActive && Input.GetKeyDown(KeyCode.Space) )
        {
            DisplayNextDialog();
        }

        if(faithnhopeCutsceneTrigger.FaithnHopeHilang && characterSpriteRenderer.sprite.name == "Faith" && characterSpriteRenderer.sprite.name == "Hope")
        {
            characterSpriteRenderer.enabled = false;
        }
        else if (MainMenu.level1 && SceneT4Bermain1.sceneMulai){
             characterSpriteRenderer.enabled = true;
        }
    }

    // Displays the next dialog in the sequence
    void DisplayNextDialog()
    {
        currentIndex++;

        if (currentIndex < dialogs.Length)
        {
            dialogTexts.text = dialogs[currentIndex];
            namaCharacter.text = namaYgNgomong[currentIndex];
            imageDisplay.sprite = imageList[currentIndex];
        }
        else
        {
            sudahNgomong = true;
            EndDialog();
        }
    }

    // Ends the dialog sequence
    void EndDialog()
    {
        dialogBox.SetActive(false);
        isDialogActive = false;
        currentIndex = 0;
        if(sudahNgomong){
            jmlhPerkenalan++;
        }
        // Additional logic after the dialog ends
    }

    void Zachtalking()
    {
        if (characterSpriteRenderer.sprite.name == "Zach") // Check if the sprite is Zach
        {
            // Perform actions specific to Zach's dialogues or behavior here
            Debug.Log("Zach is talking!");
            if(faithnhopeCutsceneTrigger.FaithnHopeHilang)
            {

            }
        }
    }

}


