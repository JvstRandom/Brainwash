using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZachManager : MonoBehaviour
{
    public Transform Frey;
    private Rigidbody2D rb;
    public Animator anim_z;
    public float radius;
    public KeyCode TombolFollow;
    public float speed;

    public bool isInRange_z;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim_z = GetComponent<Animator>();
        Frey = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isInRange_z)
        {
            if(Input.GetKeyDown(TombolFollow))
            {
                Debug.Log("TombolFollow");
                if(Vector3.Distance(Frey.position, transform.position) > radius)
                {
                    transform.position = Vector3.MoveTowards(transform.position, Frey.position, speed * Time.deltaTime);
                    anim_z.SetBool("isMoving", true);
                    changeAnimation(transform.position);

                } else {
                    anim_z.SetBool("isMoving", false);
                }
            }
        }
        
    }

    void setFloatAnim(Vector2 setvector){
        anim_z.SetFloat("moveX", setvector.x);
        anim_z.SetFloat("moveY", setvector.y);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange_z = true;
            Debug.Log("Player is in zach's range");
        }
    }
}
