using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class suster : monster
{

    private Rigidbody2D rbs;
    public Transform player;
    public Animator animS;
    public Vector2 newPosition;
    public bool isPlayerHit;

    public GameObject dialogPanel;
    public Text dialogTxt;

    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponent<Rigidbody2D>();
        animS = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
        dialogPanel.SetActive(false);
    }

    void FixedUpdate()
    {
        if(Vector3.Distance(player.position, transform.position) <= chaseRadius 
        && Vector3.Distance(player.position, transform.position) > attackRadius 
        && !isPlayerHit
        && !LokerController.isHiding)
        {
            Vector3 temp = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

            rbs.MovePosition(temp);
            animS.SetBool("isWalk", true);

            changeAnimation(temp-transform.position);
        } else if (isPlayerHit){
            rbs.velocity = Vector3.zero;
            animS.SetBool("isWalk", false);
        } else {
            animS.SetBool("isWalk", false);
        }
    }
    
    void setFloatAnim(Vector2 setvector){
        animS.SetFloat("moveX", setvector.x);
        animS.SetFloat("moveY", setvector.y);
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

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("player hit suster");
            dialogPanel.SetActive(true);
            dialogTxt.text = "Ngapain kamu di lorong ini? ini bukan waktunya jalan-jalan";
            Invoke("playerTransfer", 2f);
            isPlayerHit = true;
        } else {
            isPlayerHit = false;
        }

        // if(gamemode day3 && col.gameObject.tag == "Player"){
        //     gameOver;
        // }
    }

    void playerTransfer()
    {
        player.position = newPosition;
        dialogPanel.SetActive(false);
        isPlayerHit = false;
    }
}
