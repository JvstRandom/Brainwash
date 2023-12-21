using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneController : MonoBehaviour
{
    public bool IsOpen;
    public Animator animator;

    [SerializeField]
    GameObject SceneTransition;
    public AudioClip bukaPintu;
    public AudioClip nutupPintu;

    public AudioSource audioSumber;

    private void Start()
    {
        SceneTransition.SetActive(false);
        audioSumber = GetComponent<AudioSource>();
    }

    public void PintuDibuka()
    {
        if (!IsOpen)
        {
            audioSumber.clip = bukaPintu;
            audioSumber.Play();
            IsOpen = true;
            Debug.Log("Pintu Dibuka");
            animator.SetBool("isOpen", IsOpen);
            SceneTransition.SetActive(true);
        }
        else
        {
            audioSumber.clip = nutupPintu;
            audioSumber.Play();
            soundControll.PlaySound("closedoor");
            IsOpen = false;
            animator.SetBool("isOpen", IsOpen);
        }
    }
}
