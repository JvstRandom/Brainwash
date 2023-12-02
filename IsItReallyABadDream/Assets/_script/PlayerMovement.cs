using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState {
    walk,
    interact, 
    hurt
}

public class PlayerMovement : MonoBehaviour
{
    public PlayerState currentState;
    private Rigidbody2D rb;

    public Animator anim;
    public float speed, x, y;

    float kecepatanLari;

    private bool isWalking;
    private Vector3 moveDirection;
    public VectorValue masukScenePos;
    public KeyCode TombolInteract;

    [SerializeField]
    GameObject CodePanel;

    private void Start()
    {
        currentState = PlayerState.walk;
        rb = GetComponent<Rigidbody2D>();
        transform.position = masukScenePos.initialValue;
        kecepatanLari = speed *2;
        CodePanel.SetActive (false);
    }

    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        // if(Input.GetButtonDown("hurt") && currentState != PlayerState.hurt)
        // {
        //     //player is hurt pake coroutine
        // }

        if (x != 0 || y != 0)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
            if (!isWalking)
            {
                isWalking = true;
                anim.SetBool("isMoving", isWalking);
            }
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                anim.SetBool("isMoving", isWalking);
                StopMoving();
            }
        }

        moveDirection = new Vector3(x, y).normalized;
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(TombolInteract))
            {
                rb.velocity = moveDirection * kecepatanLari * Time.deltaTime;
            }else {
                rb.velocity = moveDirection * speed * Time.deltaTime;
            }
    }

    private void StopMoving()
    {
        rb.velocity = Vector3.zero;
    }

}
