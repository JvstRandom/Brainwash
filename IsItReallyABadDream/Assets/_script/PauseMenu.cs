using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject Pausemenu;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        Pausemenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused)
            {
                ResumeGame();
            } else {
                pauseGame();
            }
        }
    }

    public void pauseGame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
