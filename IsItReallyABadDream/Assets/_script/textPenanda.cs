using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textPenanda : MonoBehaviour
{
    public Text textinstruksi;
    public string instruksinya;
    public GameObject instruksi;
    // Start is called before the first frame update
    void Start()
    {
        instruksi.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            textinstruksi.text = instruksinya;
            instruksi.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                instruksi.SetActive(false);
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            instruksi.SetActive(false);
        }
    }
}
