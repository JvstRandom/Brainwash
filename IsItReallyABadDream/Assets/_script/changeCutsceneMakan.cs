using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeCutsceneMakan : MonoBehaviour
{
    public string sceneToload;
    public float changetime;
    public static bool cutsceneMakan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerCutsceneMakan.hasloadedscene && triggerTidur.level4)
        {
            changetime -= Time.deltaTime;
            
            if (changetime <= 0)
            {
                SceneManager.LoadScene(sceneToload);
                cutsceneMakan = true;
            }
        }
    }
}
