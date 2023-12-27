using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bukuZach : MonoBehaviour
{
    public VectorValue playerMemorys;
    public static bool level5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectImage.sdhlihatbuku && triggerTidur.level4)
        {
            playerMemorys.initialValue = new Vector2(-5.5f, 1.3f);
            SceneManager.LoadScene("kamar1");
            level5=true;
            triggerTidur.level4 = false;
        }
    }
}
