using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour
{
    // Make health and maxHealth static to ensure persistence across scenes
    public static int health;
    public static int maxHealth = 8;

    void Start()
    {
        health = maxHealth;
    }

    public static void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Game Over");
            // Handle game over logic
        }
    }

    public static void Healed(int heal)
    {
        health += heal;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
