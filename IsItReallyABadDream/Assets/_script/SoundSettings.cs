using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public Toggle muteToggle;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        muteToggle.isOn = PlayerPrefs.GetInt("IsMuted", 0) == 1;

        ApplyMute();
    }

    public void ToggleMute()
    {
        bool isMuted = !muteToggle.isOn;

        PlayerPrefs.SetInt("IsMuted", isMuted ? 1 : 0);
        PlayerPrefs.Save();
        ApplyMute();
    }

    void ApplyMute()
    {
        if(audioSource != null)
        {
            audioSource.mute = PlayerPrefs.GetInt("IsMuted", 0) == 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
