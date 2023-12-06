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

    public healthSystem playerHealth;

    void Update() {

        if(playerHealth.health>jmlHearts) {
            playerHealth.health = jmlHearts;
        }

        for(int i = 0; i < hearts.Length; i++) {

            if(i < playerHealth.health) {
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }

            if(i < jmlHearts){
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }
    }
}
