using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject setting;
    public static bool level1;
     public VectorValue playerMemorys;

    void Start()
    {
        setting.SetActive(false);
    }
    public void PlayGame()
    {
        if(!triggerTidur.lvl1completed)
        {
            level1 = true;
            SceneManager.LoadScene("kamar1");
        } else if (triggerTidur.level2)
        {
            SceneManager.LoadScene("kamar1 NM");
        }else if (triggerTidur.level4)
        {
            SceneManager.LoadScene("dapurNM");
            playerMemorys.initialValue = new Vector2(2.7f, -8.6f);
        }
        else if (bukuZach.level5)
        {
            if(PlayerManager.haveKey)
            {
                PlayerManager.haveKey=false;
            }
            SceneManager.LoadScene("kamar1");
        } else if (triggerSleseLevel6.level7)
        {
            SceneManager.LoadScene("kamar1");
            if(PlayerManager.havePotion)
            {
                PlayerManager.havePotion=false;
            }
            if(PlayerManager.haveMapLabirin)
            {
                PlayerManager.haveMapLabirin = false;
            }
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
