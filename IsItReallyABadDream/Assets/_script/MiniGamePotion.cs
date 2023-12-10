using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MiniGamePotion : MonoBehaviour
{
    public Text hasilTxt;
    public float num1 = 0f;
    public float num2 = 0f;
    public string operation;
    public Sprite rightPotion;
    public Sprite emptyPotion;
    public Sprite wrongPotion;


    public void i_pertambahan()
    {
        num1 = float.Parse(hasilTxt.text);
        operation = ("+");
        hasilTxt.text = float.Parse(hasilTxt.text) + (" + ");
    }

    public void i_pengurangan()
    {
        num1 = float.Parse(hasilTxt.text);
        operation = ("-");
        hasilTxt.text = float.Parse(hasilTxt.text) + (" - ");
    }

    public void i_pembagian()
    {
        num1 = float.Parse(hasilTxt.text);
        operation = ("/");
        hasilTxt.text = float.Parse(hasilTxt.text) + (" / ");
    }

    public void i_perkalian()
    {
        num1 = float.Parse(hasilTxt.text);
        operation = ("*");
        hasilTxt.text = float.Parse(hasilTxt.text) + (" * ");
    }

    // public void AddNumPotion(float num) {
    //     KodeBrankas += num;
    // }

    public void potionMerah()
    {
        if (hasilTxt.text == Convert.ToString("0"))
        {
            hasilTxt.text = "2";
        }
        else
        {
            hasilTxt.text = hasilTxt.text + "2";
        }
    }

    public void potionKuning()
    {
        if (hasilTxt.text == Convert.ToString("0"))
        {
            hasilTxt.text = "5";
        }
        else
        {
            hasilTxt.text = hasilTxt.text + "5";
        }
    }

    public void potionBiru()
    {
        if (hasilTxt.text == Convert.ToString("0"))
        {
            hasilTxt.text = "10";
        }
        else
        {
            hasilTxt.text = hasilTxt.text + "10";
        }
    }

    public void potionHijau()
    {
        if (hasilTxt.text == Convert.ToString("0"))
        {
            hasilTxt.text = "20";
        }
        else
        {
            hasilTxt.text = hasilTxt.text + "20";
        }
    }
}
