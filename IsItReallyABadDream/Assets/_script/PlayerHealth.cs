using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int jmlHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
            // Use the static reference for health updates
            if (healthSystem.health > jmlHearts)
            {
                healthSystem.health = jmlHearts;
            }

            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < healthSystem.health)
                {
                    hearts[i].sprite = fullHeart;
                }
                else
                {
                    hearts[i].sprite = emptyHeart;
                }

                hearts[i].enabled = i < jmlHearts;
            }
        
    }
}
