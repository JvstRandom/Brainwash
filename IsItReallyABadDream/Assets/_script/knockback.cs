using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float force;
    public float durasiKnock;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player")){
            Debug.Log("player in range");
            Rigidbody2D player = col.GetComponent<Rigidbody2D>();
            if(player != null){
                Vector2 jarak = player.transform.position - transform.position;
                jarak = jarak.normalized * force;
                player.AddForce(jarak, ForceMode2D.Impulse);
                StartCoroutine(Knock(player));
            }
        }
    }

    private IEnumerator Knock(Rigidbody2D player)
    {
        if(player != null){
            yield return new WaitForSeconds(durasiKnock);
            player.velocity = Vector2.zero;
        }
    }

}
