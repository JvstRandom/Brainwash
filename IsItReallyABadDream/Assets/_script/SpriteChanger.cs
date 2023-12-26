using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    //change sprite
    public Sprite newSprite; // Reference to the new sprite to be displayed
    private SpriteRenderer spriteRenderer;

    //dialog chice box
    public GameObject dialogChoiceBox;
    public Text dialogTexts;
    public string dialog1;
    public string[] dialogs;

    public static int jmlhNyentuhBendaMemori = 0;
    public static bool sudahLevel3=false;
    public bool playerChoice;
    public bool PlayerInRange;

    //display image
    public Image imageDisplay; // Reference to the Image UI object
    public Sprite[] imageList; // List of sprites/images to display
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        dialogChoiceBox.SetActive(false);
        imageDisplay.enabled = false;
        playerChoice = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && PlayerInRange && triggerSleseNM1.level3)
        {
            
            if (dialogChoiceBox.activeInHierarchy)
            {
                dialogChoiceBox.SetActive(false);
                imageDisplay.enabled = false;
            }
            else 
            {
                dialogChoiceBox.SetActive(true);
                dialogTexts.text = dialog1;
                imageDisplay.enabled = false;
            }
        }

        if(jmlhNyentuhBendaMemori == 3)
        {
            sudahLevel3=true;
            Debug.Log("sjumlah = " + jmlhNyentuhBendaMemori);
            dialogChoiceBox.SetActive(true);
            dialogTexts.text = "sepertinya itu sudah semua, mungkin jika aku kembali ke kamar aku akan bangun";
            if(Input.GetKeyDown(KeyCode.Space))
            {
                dialogChoiceBox.SetActive(false);
            }
        }
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && triggerSleseNM1.level3)
        {
            PlayerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerInRange = false;
            dialogChoiceBox.SetActive(false);
        }
    }

    public void choiceYes(){
        playerChoice = true;
        imageDisplay.enabled = true;
        DisplayNextImage();
        // if(Input.GetKeyDown(KeyCode.I)){
        //     Debug.Log("Entering");
        //     DisplayNextImage();
        // }
    }

    public void choiceNo(){
        playerChoice = false;
        dialogChoiceBox.SetActive(false);
        imageDisplay.enabled = false;
    }

    public void DisplayNextImage()
    {
        if (currentIndex < imageList.Length)
        {
            // Display the next image
            imageDisplay.sprite = imageList[currentIndex];
            dialogTexts.text = dialogs[currentIndex];
            currentIndex++;

            // Check if it's the end of the image list
            if (currentIndex == imageList.Length)
            {
                Debug.Log("End of image sequence");
                spriteRenderer.sprite = newSprite;
                jmlhNyentuhBendaMemori++;
                // You can perform any actions here when the sequence ends
            }
        }
    }
}
