using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer MainMixer;
    [SerializeField] private Slider musicSlider; 

    public const string MIXER_MUSIC = "MusicVolume";

    void Awake()
    {
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
    } 

    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
    }

    void SetMusicVolume(float value)
    {
        MainMixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }
}
