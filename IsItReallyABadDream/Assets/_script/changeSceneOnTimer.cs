using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneOnTimer : MonoBehaviour
{
    public string sceneToLoad2;
    public float changeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(faithnhopeCutsceneTrigger.hasLoadedScene && !faithnhopeCutsceneTrigger.sdhBerubah)
        {
            changeTime -= Time.deltaTime;
            if (changeTime <= 0)
            {
                SceneManager.LoadScene(sceneToLoad2);
                faithnhopeCutsceneTrigger.FaithnHopeHilang = true;
                faithnhopeCutsceneTrigger.sdhBerubah = true;
            }
        }else 
        {
            changeTime -= Time.deltaTime;
            if (changeTime <= 0)
            {
                SceneManager.LoadScene(sceneToLoad2);
            }
        }
    }
}
