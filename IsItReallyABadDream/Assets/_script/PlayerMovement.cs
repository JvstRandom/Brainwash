using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
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



    public float KnockForce;
    public float KBCounter;
    public float KnockDurasi;

    public bool knockKanan;

    public AudioClip newClip;

    public AudioSource newSource;
    private void Start()
    {
        currentState = PlayerState.walk;
        rb = GetComponent<Rigidbody2D>();
        transform.position = masukScenePos.initialValue;
        kecepatanLari = speed * 2;
        newSource = GetComponent<AudioSource>();
        newSource.clip = newClip;
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
                newSource.Play();
            }
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                newSource.Stop();
                anim.SetBool("isMoving", isWalking);
                StopMoving();
            }
        }

        moveDirection = new Vector3(x, y).normalized;
    }

    private void FixedUpdate()
    {
        if (KBCounter <= 0)
        {
            if (Input.GetKey(TombolInteract))
            {
                rb.velocity = moveDirection * kecepatanLari * Time.deltaTime;
            }
            else
            {
                rb.velocity = moveDirection * speed * Time.deltaTime;
            }
        }
        else
        {

            if (!knockKanan)
            {
                rb.velocity = new Vector3((x + KnockForce), (y - KnockForce / 2));
            }
            else
            {
                rb.velocity = new Vector3((x - KnockForce), (KnockForce / 2));
            }
            KBCounter -= Time.deltaTime;
        }

    }

    public void StopMoving()
    {
        rb.velocity = Vector3.zero;
    }

}
