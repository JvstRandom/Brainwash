using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] AudioMixer MainMixer;

    public const string MUSIC_KEY = "MusicVolume";

    void Awake()
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadVolume();
    }

    void LoadVolume() //Volume tersimpan di AudioSettings.cs
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1f);

        MainMixer.SetFloat(AudioSettings.MIXER_MUSIC, Mathf.Log10(musicVolume) * 20);
    }
}