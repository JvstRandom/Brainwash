using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogTrigger : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogTexts;
    public string[] dialogs;
    public Text namaCharacter;
    public string[] namaYgNgomong;

    public Image imageDisplay; // Reference to the Image UI object
    public Sprite[] imageList; // List of sprites/images to display
    private int currentIndex = 0;
    public static bool isZachDialog1End;
    

    // Start is called before the first frame update
    void Start()
    {
        imageDisplay.enabled = false;
        dialogBox.SetActive(false);
        isZachDialog1End = false;
    }

    // Call this method to start a specific dialog sequence
    public void StartDialogSequence(Sprite[] images, string[] dialogText, string[] characterNames)
    {
        if (images.Length == dialogText.Length && dialogText.Length == characterNames.Length)
        {
            imageList = images;
            dialogs = dialogText;
            namaYgNgomong = characterNames;

            imageDisplay.enabled = true;
            dialogBox.SetActive(true);
            currentIndex = 0;
            DisplayNextImage();
        }
        else
        {
            Debug.LogError("Arrays of different lengths. Dialog sequence cannot start.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Modify your conditions here to trigger dialog sequences as needed
        if (Input.GetKeyDown(KeyCode.Space) && dialogBox.activeSelf && !isZachDialog1End)
        {
            if (currentIndex < imageList.Length)
            {
                
                DisplayNextImage();
            }
            else
            {
                EndDialogSequence();
                isZachDialog1End = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Example: Trigger dialog sequence when the player enters a trigger zone
            StartDialogSequence(imageList, dialogs, namaYgNgomong);
        }
    }

    public void DisplayNextImage()
    {
        if (currentIndex < imageList.Length)
        {
            imageDisplay.sprite = imageList[currentIndex];
            dialogTexts.text = dialogs[currentIndex];
            namaCharacter.text = namaYgNgomong[currentIndex];
            currentIndex++;
        }
    }

    public void EndDialogSequence()
    {
        // Perform actions when the dialog sequence ends
        dialogBox.SetActive(false);
        imageDisplay.enabled = false;
        currentIndex = 0;
        // Additional logic or actions when the dialog ends
    }
}
