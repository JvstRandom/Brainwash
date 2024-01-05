using UnityEngine;
using UnityEngine.UI;

public class FollowerTrigger : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Transform follower; // Reference to the character to become the follower

    public static bool ZachisFollowing = false;

    public dialog ZachikutDialog;
    public GameObject npcSprite;
    public bool percakapanzachikut;
    private bool dialogslese;

    void Start()
    {
        npcSprite.SetActive(false);
        percakapanzachikut = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && MainMenu.level1 && faithnhopeCutsceneTrigger.FaithnHopeHilang 
        && !percakapanzachikut && !triggerNguping.sceneEavesdrop && !dialogslese)
        {
            Debug.Log("player memenuhi syarat");
            npcSprite.SetActive(true);
            FindObjectOfType<DialogManager>().StartDialog(ZachikutDialog);
            percakapanzachikut = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && percakapanzachikut)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
            if (!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                StartFollowing();
                dialogslese = true;
            }
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

