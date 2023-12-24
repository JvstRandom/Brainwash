using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZachManager : MonoBehaviour
{
    public Transform frey;
    private Rigidbody2D rb;
    public Animator anim_z;
    public float radius;
    public KeyCode TombolFollow;
    public float speed;
    public bool isFollow;
    public bool isInRange_z;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim_z = GetComponent<Animator>();
        frey = GameObject.FindWithTag("Player").transform;
    }

    void Update(){
        if(Input.GetKeyDown(TombolFollow))
            {
                isFollow = true;
                Debug.Log("Player folow");
            }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if((isInRange_z && isFollow) || FollowerTrigger.ZachisFollowing)
        {
                if(Vector3.Distance(frey.position, transform.position) > radius)
                {
                    Vector3 temp = Vector3.MoveTowards(transform.position, frey.position, speed * Time.deltaTime);
                    rb.MovePosition(temp);
                    anim_z.SetBool("isMoving", true);
                    changeAnimation(temp - transform.position);

                } else {
                    anim_z.SetBool("isMoving", false);
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
