using UnityEngine;
using UnityEngine.UI;

public class FollowerTrigger : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Transform follower; // Reference to the character to become the follower

    private bool isFollowing = false;
    private bool dialogueCompleted = false; // Flag to track if dialogue is completed

    public GameObject dialogBox;
    public Text dialogTexts;
    public string[] dialogs;
    public Text namaCharacter;
    public string[] namaYgNgomong;

    public Image imageDisplay; // Reference to the Image UI object
    public Sprite[] imageList; // List of sprites/images to display
    private int currentIndex = 0;
    public GameObject npcSprite;

    void Start()
    {
        npcSprite.SetActive(false);
        dialogBox.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !dialogueCompleted) // Check if the player enters the trigger and dialogue is not completed
        {
            StartDialogue();
        }
    }

    private void Update()
    {
        if (isFollowing && MainMenu.level1 && !isFollowing)
        {
            // Make the follower follow the player's position
            follower.position = player.position;
        }
    }

    void StartDialogue()
    {
        npcSprite.SetActive(true);
        dialogBox.SetActive(true); // Show the dialog box UI

        // Set the text and character's name based on currentIndex
        dialogTexts.text = dialogs[currentIndex];
        namaCharacter.text = namaYgNgomong[currentIndex];
        imageDisplay.sprite = imageList[currentIndex];

        // Increment the currentIndex to progress through the dialogue
        currentIndex++;

        // Check if the dialogue is completed
        if (currentIndex >= dialogs.Length)
        {
            dialogueCompleted = true;
            dialogBox.SetActive(false); // Hide the dialog box UI after dialogue completion
            StartFollowing(); // Start following the player after dialogue
        }
    }

    void StartFollowing()
    {
        isFollowing = true;
        Debug.Log(follower.name + " is now following " + player.name);
        // Add any additional logic here if needed when the follower starts following
    }

    public void StopFollowing()
    {
        isFollowing = false;
        Debug.Log(follower.name + " is now not following " + player.name);
    }
}
