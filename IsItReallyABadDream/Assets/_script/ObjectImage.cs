using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectImage : MonoBehaviour
{
    public GameObject place;
    public Image PlaceImageToShow;
    public bool UiAktif;
    public AudioSource audioSource;
    public static bool sdhlihatbuku = false;
    public static bool sdhlevel8;
    public Sprite ImageYoShow;
    public VectorValue playerMemorys;
    public static bool level9;

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
            if(triggerTidur.level4)
            {
                sdhlihatbuku = true;
            } else if(triggerTidur.level8)
            {
                triggerTidur.level8 = false;
                sdhlevel8 = true;
                level9 = true;
                SceneManager.LoadScene("kamar1");
                playerMemorys.initialValue = new Vector2(-5.5f, 1.3f);
            }
        }
        
    }


}

