using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerSleseNM1 : MonoBehaviour
{
    public static bool level3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("jumlah nyentuh = "+ bendaMemoriNm.jmlhNyentuhBendaMemoriNM);
        if(bendaMemoriNm.jmlhNyentuhBendaMemoriNM == 3 && triggerTidur.level2)
        {
            
            SceneManager.LoadScene("kamar1");
            bendaMemoriNm.jmlhNyentuhBendaMemoriNM--;
            level3=true;
        }
    }
}
