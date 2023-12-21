using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundControll : MonoBehaviour
{
    public static AudioClip playerHit, playerRun, itemFound,
    playerWalk, dikejar, bukaPintu, nutupPintu, bukaLaci, nutupLaci, bukaNutupLoker;

    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        playerHit = Resources.Load<AudioClip>("PlayerHit");
        playerRun = Resources.Load<AudioClip>("run");
        itemFound = Resources.Load<AudioClip>("itemfound");
        playerWalk = Resources.Load<AudioClip>("footstep");
        dikejar = Resources.Load<AudioClip>("heartbeat");
        bukaPintu = Resources.Load<AudioClip>("opendoor");
        nutupPintu = Resources.Load<AudioClip>("closedoor");
        bukaLaci = Resources.Load<AudioClip>("openDrawer");
        nutupLaci = Resources.Load<AudioClip>("closeDrawer");
        // bukaNutupLoker = Resources.Load<AudioClip> ("");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string sound)
    {
        switch (sound)
        {
            case "PlayerHit":
                audioSource.PlayOneShot(playerHit);
                break;
            case "run":
                audioSource.PlayOneShot(playerRun);
                break;
            case "itemfound":
                audioSource.PlayOneShot(itemFound);
                break;
            case "footstep":
                audioSource.PlayOneShot(playerWalk);
                break;
            case "heartbeat":
                audioSource.PlayOneShot(dikejar);
                break;
            case "opendoor":
                audioSource.PlayOneShot(bukaPintu);
                break;
            case "closedoor":
                audioSource.PlayOneShot(nutupPintu);
                break;
            case "openDrawer":
                audioSource.PlayOneShot(bukaLaci);
                break;
            case "closeDrawer":
                audioSource.PlayOneShot(nutupLaci);
                break;
                // case "":
                //     audioSource.PlayOneShot(bukaNutupLoker);
                //     break;
        }
    }
}
