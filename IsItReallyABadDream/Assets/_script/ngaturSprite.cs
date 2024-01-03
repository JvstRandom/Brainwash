using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ngaturSprite : MonoBehaviour
{
    public SpriteRenderer characterSR;
    public GameObject Zach1;

    // Start is called before the first frame update
    void Start()
    {
        characterSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if((MainMenu.level1 && !SceneT4Bermain1.sceneMulai) || triggerPercakapandokter.sdhlvl1)
        {
            characterSR.enabled = true;   
        } else {
            characterSR.enabled = false;
            Destroy(Zach1);
        }
    }
}
