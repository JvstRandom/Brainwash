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
        if(!triggerTidur.lvl1completed)
        {
            level1 = true;
        } else 
        {
            
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
