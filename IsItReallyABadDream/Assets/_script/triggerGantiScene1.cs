using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGantiScene1 : MonoBehaviour
{
    [SerializeField]
    GameObject SceneTransition;
    // Start is called before the first frame update
    void Start()
    {
        SceneTransition.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("status dialog end zach = " + dialogTrigger.isZachDialog1End);
        if (MainMenu.level1 && dialogTrigger.isZachDialog1End)
        {
            SceneTransition.SetActive(true);
            dialogTrigger.isZachDialog1End = false;
        } 
    }
}
