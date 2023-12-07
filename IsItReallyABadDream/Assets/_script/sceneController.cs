using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneController : MonoBehaviour
{
    public bool IsOpen;
    public Animator animator;

    [SerializeField]
    GameObject SceneTransition;

    private void Start()
    {
        SceneTransition.SetActive (false);
    }

    public void PintuDibuka()
    {
        if(!IsOpen) 
        {
            IsOpen = true;
            Debug.Log("Pintu Dibuka");
            animator.SetBool("isOpen", IsOpen);
            SceneTransition.SetActive (true);
        }else
        {
            IsOpen = false;
            animator.SetBool("isOpen", IsOpen);
        }
    }
}
