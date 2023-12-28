using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_labirin : monster
{
    private Rigidbody2D rbml;
    public Transform player;
    public Animator animMl;
    public Transform spawnPoint;
    public bool isPlayerHit;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        rbml = GetComponent<Rigidbody2D>();
        animMl = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!PlayerManager.haveCostume)
        {
            Chase(chaseRadius);
        } else if(PlayerManager.haveCostume)
        {
            float jarakKostum = chaseRadius / 2;
            Chase(jarakKostum);
        }
    }

    void Chase(float jarak)
    {
        
        if(Vector3.Distance(player.position, transform.position) <= jarak 
            && Vector3.Distance(player.position, transform.position) > attackRadius 
            && !isPlayerHit
            && !LokerController.isHiding)
            {
                Vector3 temp = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

                rbml.MovePosition(temp);
                animMl.SetBool("IsMoving", true);

                changeAnimation(temp-transform.position);
            } else if (isPlayerHit){
                rbml.velocity = Vector3.zero;
                animMl.SetBool("IsMoving", false);
            } else {
                Vector3 temp = Vector3.MoveTowards(transform.position, spawnPoint.position, moveSpeed * Time.deltaTime);

                rbml.MovePosition(temp);
                animMl.SetBool("IsMoving", true);
            }
    }

    void setFloatAnim(Vector2 setvector){
        animMl.SetFloat("X", setvector.x);
        animMl.SetFloat("Y", setvector.y);
    }

    void changeAnimation(Vector2 arah)
    {
        if(Mathf.Abs(arah.x) > Mathf.Abs(arah.y))
        {
            if(arah.x > 0){
                setFloatAnim(Vector2.right);
            }else if(arah.x < 0)
            {
                setFloatAnim(Vector2.left);
            }
        }else if(Mathf.Abs(arah.x) < Mathf.Abs(arah.y))
        {
            if(arah.y > 0){
                setFloatAnim(Vector2.up);
            }else if(arah.y < 0)
            {
                setFloatAnim(Vector2.down);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerMovement.KBCounter = playerMovement.KnockDurasi;
            //jika player ada di kiri maka akan di hit dari kanan
            if (other.transform.position.x <= transform.position.x)
            {
                playerMovement.knockKanan = true;
            }
            
            if (other.transform.position.x > transform.position.x)
            {
                playerMovement.knockKanan = false;
            }

            healthSystem.TakeDamage(baseAttack);
        }
    }
}
