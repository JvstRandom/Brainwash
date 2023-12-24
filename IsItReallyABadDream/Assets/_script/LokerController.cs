using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LokerController : MonoBehaviour
{

    public GameObject player;
    public GameObject locker;
    public bool IsOpen;
    public Animator anim;

    public static bool isHiding = false;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void LokerDibuka()
    {
        if(!IsOpen && !isHiding) 
        {
            IsOpen = true;
            isHiding = true;
            audioSource.Play();

            // Move player behind or inside the locker (adjust the position accordingly)
            player.transform.position = new Vector3(locker.transform.position.x, locker.transform.position.y, player.transform.position.z);

            // Disable player's visibility
            SpriteRenderer playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
            if (playerSpriteRenderer != null)
            {
                playerSpriteRenderer.enabled = false;
            }
            anim.SetBool("isOpen", IsOpen);

        }else
        {
            IsOpen = false;
            isHiding = false;

            // Reset player's position to its original position
            double new_y_pos = locker.transform.position.y - 0.90;
            float y_pos = (float)new_y_pos;
            player.transform.position = new Vector3(locker.transform.position.x, y_pos , player.transform.position.z);

            // Enable player's visibility
            SpriteRenderer playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
            if (playerSpriteRenderer != null)
            {
                playerSpriteRenderer.enabled = true;
            }
            anim.SetBool("isOpen", IsOpen);
        }
    }
}
