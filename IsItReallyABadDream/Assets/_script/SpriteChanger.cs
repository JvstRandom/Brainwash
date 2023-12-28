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
    public static bool sdhlihatKipas=false;
    public bool playerChoice;
    public bool PlayerInRange;

    //display image
    public Image imageDisplay; // Reference to the Image UI object
    public Sprite[] imageList; // List of sprites/images to display
    private int currentIndex = 0;
    private bool sdhterakhir;

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
        if (Input.GetKeyDown(KeyCode.Space) && PlayerInRange && (bendaMemoriNm.level3 || bukuZach.level5))
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

        if(jmlhNyentuhBendaMemori == 3 && bendaMemoriNm.level3 && sdhterakhir)
        {
            sudahLevel3=true;
            Debug.Log("sjumlah = " + jmlhNyentuhBendaMemori);
            FindObjectOfType<NotificationManager>().StartNotification("sepertinya saya sudah mengecek semua barang sebaiknya aku kembali tidur karena sudah larut");
            if(Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<NotificationManager>().HideNotification();
                jmlhNyentuhBendaMemori--;
            }
        }
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") )
        {
            PlayerInRange = true;
            Debug.Log("player in range");
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
            if (currentIndex >= imageList.Length)
            {
                Debug.Log("End of image sequence");
                spriteRenderer.sprite = newSprite;
                
                sdhterakhir = true;
                if(bendaMemoriNm.level3)
                {
                    jmlhNyentuhBendaMemori++;
                } else if(bukuZach.level5)
                {
                    sdhlihatKipas=true;
                }
                Invoke("hilang", 3f);
                
                // You can perform any actions here when the sequence ends
            }
        }
    }

    void hilang()
    {
        dialogChoiceBox.SetActive(false);
        imageDisplay.enabled = false;
    }
}
