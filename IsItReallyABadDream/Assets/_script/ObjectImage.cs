using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectImage : MonoBehaviour
{
    public GameObject place;
    public Image PlaceImageToShow;
    public bool UiAktif;
    public AudioSource audioSource;

    public Sprite ImageYoShow;

    private void Start(){
        place.SetActive(false);
        PlaceImageToShow.enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    public void imageDilihatin()
    {
        if(!UiAktif)
        {
            place.SetActive(true);
            PlaceImageToShow.sprite = ImageYoShow;
            PlaceImageToShow.enabled = true;
            UiAktif = true;
            audioSource.Play();
        } else if (UiAktif){
            PlaceImageToShow.enabled = false;
            UiAktif = false;
            place.SetActive(false);
        }
        
    }
}

