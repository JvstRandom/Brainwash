using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectImage : MonoBehaviour
{
    public Image imageToShow;
    public bool UiAktif;

    private void Start(){
        imageToShow.enabled = false;
    }

    public void imageDilihatin()
    {
        if(!UiAktif)
        {
            imageToShow.enabled = true;
            UiAktif = true;
        } else if (UiAktif){
            imageToShow.enabled = false;
            UiAktif = false;
        }
        
    }
}

