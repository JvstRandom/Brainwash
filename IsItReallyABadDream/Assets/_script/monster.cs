using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState{
    idle, walk, 
}

public class monster : MonoBehaviour
{
    public EnemyState currentState;
    public string monsterName;
    public int baseAttack;
    public float moveSpeed;

    public float chaseRadius;
    public float attackRadius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
