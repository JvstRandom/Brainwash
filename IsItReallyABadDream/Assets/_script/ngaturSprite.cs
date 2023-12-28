using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ngaturSprite : MonoBehaviour
{
    public SpriteRenderer characterSR;

    // Start is called before the first frame update
    void Start()
    {
        characterSR = GetComponent<SpriteRenderer>();
        characterSR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!faithnhopeCutsceneTrigger.FaithnHopeHilang)
        {
            characterSR.enabled = true;
        }
    }
}
