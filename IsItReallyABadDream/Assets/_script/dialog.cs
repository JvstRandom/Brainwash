using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class dialog
{
    [TextArea(3, 8)]
    public string[] sentences;
    public string[] name;
    public Sprite[] image;
}
