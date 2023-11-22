using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaciController : MonoBehaviour
{
    public bool IsOpen;
    public Animator animator;

    public void LaciDibuka()
    {
        if(!IsOpen) 
        {
            IsOpen = true;
            Debug.Log("Laci Dibuka");
            animator.SetBool("isOpen", IsOpen);
        }else
        {
            IsOpen = false;
            animator.SetBool("isOpen", IsOpen);
        }
    }
}
