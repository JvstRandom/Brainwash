using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSetelahDikejar : MonoBehaviour
{
    public dialog berhasillolos;
    public static bool sdhngomongya = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && sdhngomongya)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && triggerTidur.level4 && triggerdikejar.dikejar && !sdhngomongya)
        {
            Debug.Log("sudah selesai dikejar");
            triggerdikejar.dikejar = false;
            FindObjectOfType<DialogManager>().StartDialog(berhasillolos);
            sdhngomongya = true;
        }
    }
}
