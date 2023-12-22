using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogLevel1 : MonoBehaviour
{

    public GameObject dialogBox;
    public Text dialogTexts;
    public string[] dialogs;
    public Text namaCharacter;
    public string[] namaYgNgomong;

    public Text instruksi;
    public GameObject intruksiBox;
    public string instruksiIsi;

    public Image imageDisplay; // Reference to the Image UI object
    public Sprite[] imageList; // List of sprites/images to display
    private int currentIndex = 0;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        imageDisplay.enabled = false;
        dialogBox.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MainMenu.level1)
        {
            imageDisplay.enabled = true;
            instruksi.text = instruksiIsi;
            intruksiBox.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                intruksiBox.SetActive(false);
                dialogBox.SetActive(true);
                DisplayNextImage();
            }
        }
    }

     public void DisplayNextImage()
    {
        if (currentIndex < imageList.Length)
        {
            // Display the next image
            imageDisplay.sprite = imageList[currentIndex];
            dialogTexts.text = dialogs[currentIndex];
            namaCharacter.text = namaYgNgomong[currentIndex];
            currentIndex++;
        } else {
            imageDisplay.enabled = false;
                dialogBox.SetActive(false);
                Debug.Log("End of image sequence");
                // You can perform any actions here when the sequence ends
        }
    }
}
