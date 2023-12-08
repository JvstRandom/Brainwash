using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brankasController : MonoBehaviour
{

    [SerializeField]
    GameObject CodePanel;

    public static bool isSafeOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        CodePanel.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSafeOpened) {
            CodePanel.SetActive (false);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.CompareTag("brankas") && !isSafeOpened) {
            Debug.Log("Player is in range");
            CodePanel.SetActive (true);
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if(col.gameObject.CompareTag("brankas")) {
            CodePanel.SetActive (false);
        }
    }
}
