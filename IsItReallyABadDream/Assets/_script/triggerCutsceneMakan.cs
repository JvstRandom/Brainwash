using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class triggerCutsceneMakan : MonoBehaviour
{
    public static bool cutscene = false;
    public dialog masukLvl4;
    public string sceneToLoad;
    public static bool hasloadedscene = false;
    // Start is called before the first frame update
    void Start()
    {
        triggerTidur.level4 = true;
        // if(triggerTidur.level4 && !cutscene)
        // {
        //     FindObjectOfType<DialogManager>().StartDialog(masukLvl4);
        //     cutscene=true;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerTidur.level4 && cutscene && Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
            if (!hasloadedscene && !FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                SceneManager.LoadScene(sceneToLoad);
                hasloadedscene = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("bisa");
            if (triggerTidur.level4 && !cutscene)
            {
                Debug.Log("Harusnya muncul");
                FindObjectOfType<DialogManager>().StartDialog(masukLvl4);
                cutscene = true;
            }
        }
    }
}
