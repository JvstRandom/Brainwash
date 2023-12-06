using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_nightmare : monster
{
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform spawnPoint;

    public healthSystem  playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckRadius();
    }

    void CheckRadius()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius
        && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            playerHealth.TakeDamage(baseAttack);
        }
    }
}
