using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0) {
            Debug.Log("Game Over");
            // Destroy(gameObject);
        }
    }
}