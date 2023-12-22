using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject setting;
    public static bool level1;

    void Start()
    {
        setting.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("kamar1");
        level1 = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
