using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class faithnhopeCutsceneTrigger : MonoBehaviour
{
    public GameObject faith;
    public GameObject hope;
    public GameObject suster;
    public string sceneToLoad;
    public static bool hasLoadedScene = false;
    public static bool sdhBerubah = false;
    public static bool FaithnHopeHilang = false;
    public SpriteRenderer characterSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        characterSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("FaithnHopeHilang: " + FaithnHopeHilang);
        Debug.Log("ngomongKeNPC.jmlhPerkenalan: " + ngomongKeNPC.jmlhPerkenalan);
       if (ngomongKeNPC.jmlhPerkenalan == 5 && !hasLoadedScene && !sdhBerubah)
        {
            SceneManager.LoadScene(sceneToLoad);
            hasLoadedScene = true;
            
        }


        if(FaithnHopeHilang)
        {
            if (hope != null) Destroy(hope);
            if (faith != null) Destroy(faith);
            if (suster != null) Destroy(suster);
        }
        else if (MainMenu.level1 && SceneT4Bermain1.sceneMulai){
            characterSpriteRenderer.enabled = true;
        }
    }
}
