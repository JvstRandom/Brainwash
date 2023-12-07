using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public Animator CamAnim;

    public void CamShake(){
        CamAnim.SetBool("isShake", true);
    }

    public void CamStop(){
        CamAnim.SetBool("isShake", false);
    }
}
