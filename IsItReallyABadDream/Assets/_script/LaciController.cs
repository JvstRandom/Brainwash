using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaciController : MonoBehaviour
{
    public bool IsOpen;
    public Animator animator;

    [SerializeField]
    GameObject SceneTransition;

    private void Start()
    {
        SceneTransition.SetActive (false);
    }

    public void LaciDibuka()
    {
        if(!IsOpen) 
        {
            IsOpen = true;
            Debug.Log("Laci Dibuka");
            animator.SetBool("isOpen", IsOpen);
            SceneTransition.SetActive (true);
        }else
        {
            IsOpen = false;
            animator.SetBool("isOpen", IsOpen);
        }
    }
}
