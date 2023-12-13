using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject setting;

    void Start()
    {
        setting.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("kamar1");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
