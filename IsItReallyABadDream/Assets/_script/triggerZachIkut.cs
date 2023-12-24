using UnityEngine;
using UnityEngine.UI;

public class FollowerTrigger : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Transform follower; // Reference to the character to become the follower

    public static bool ZachisFollowing = false;
    private bool dialogueCompleted = false; // Flag to track if dialogue is completed

    public dialog ZachikutDialog;
    public GameObject npcSprite;
    public bool percakapanzachikut = false;

    void Start()
    {
        npcSprite.SetActive(false);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !dialogueCompleted && MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang && !percakapanzachikut)
        {
            Debug.Log("player memenuhi syarat");
            percakapanzachikut = true;
            npcSprite.SetActive(true);
            FindObjectOfType<DialogManager>().StartDialog(ZachikutDialog);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && percakapanzachikut)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();  
        }
        if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
        {
            StartFollowing();
            
        }
    }

    void StartFollowing()
    {
        ZachisFollowing = true;
    }

    public void StopFollowing()
    {
        ZachisFollowing = false;
        Debug.Log(follower.name + " is now not following " + player.name);
    }
}

