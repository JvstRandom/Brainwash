using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerSleseLevel6 : MonoBehaviour
{
    public VectorValue playerMemorys;
    private bool sdhnotif = false;
    public static bool level7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sdhnotif && Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<NotificationManager>().HideNotification();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && triggerTidur.level6)
        {  
            if(!triggerPapan.sdhLevel6)
            {
                FindObjectOfType<NotificationManager>().StartNotification("Apakah kamu yakin sudah mengecek semua clue?, coba cari lagi");
                sdhnotif=true;
            } else {
                playerMemorys.initialValue = new Vector2(-5.5f, -1.3f);
                SceneManager.LoadScene("kamar1");
                level7=true;
                triggerTidur.level6=false;
            }
        }
    }
}
