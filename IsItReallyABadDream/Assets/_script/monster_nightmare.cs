using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_nightmare : monster
{
    private Rigidbody2D rbm;
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform spawnPoint;

    public Animator anim;

    public healthSystem  playerHealth;

    public PlayerMovement playerMovement;

    private shake camShake;

    // Start is called before the first frame update
    void Start()
    {
        // currentState = EnemyState.idle;
        rbm = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        camShake = GameObject.FindGameObjectWithTag("screenShake").GetComponent<shake>();
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        CheckRadius();
    }

    void CheckRadius()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius
        && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);


            rbm.MovePosition(temp);
            // ChangeState(EnemyState.walk);
            anim.SetBool("isJalan", true);
            changeAnim(temp - transform.position);

            // cam shake
            camShake.CamShake(); 
            
        } else {
            camShake.CamStop();
            // ChangeState(EnemyState.idle);
            anim.SetBool("isJalan", false);
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

            playerHealth.TakeDamage(baseAttack);
        }
    }

    void ChangeState(EnemyState newState) 
    {
        if(currentState != newState) 
        {
            currentState = newState;
        }
    }

    void setFloatAnim(Vector2 setvector){
        anim.SetFloat("moveX", setvector.x);
        anim.SetFloat("moveY", setvector.y);
    }

    void changeAnim(Vector2 arah)
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
}

