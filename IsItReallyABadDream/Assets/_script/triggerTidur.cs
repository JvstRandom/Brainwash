using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerTidur : MonoBehaviour
{
    public string notifikasituru;
    public string notifikasigturu;
    public VectorValue playerMemorys;
    private bool sdhnotif =false;
    public static bool level2;
    public static bool level4;
    public static bool level6;
    public static bool level8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) && sdhnotif)
        {
            
            FindObjectOfType<NotificationManager>().HideNotification();
            if(triggerPercakapandokter.sdhlvl1){
                MainMenu.level1 = false;
                triggerPercakapandokter.sdhlvl1 = false;
                level2 = true;
                SceneManager.LoadScene("kamar1 NM");
                playerMemorys.initialValue = new Vector2(-5.5f, 1.3f);
            }else if(bendaMemoriNm.sdhsemua){
                bendaMemoriNm.level3 = false;
                level4 = true;
                Debug.Log("level 4 ="+ level4);
                SceneManager.LoadScene("dapurNM");
                playerMemorys.initialValue = new Vector2(-4.9f, -3.0f);
            } else if(triggerSudahSleseLevel5.sdhlvl5)
            {
                bukuZach.level5=false;
                level6 = true;
                Debug.Log("level 6 ="+ level6);
                SceneManager.LoadScene("dapurNM");
                playerMemorys.initialValue = new Vector2(-4.9f, -3.0f);
            } else if(ngomongKeNPC.sdhLevel7)
            {
                triggerSleseLevel6.level7 = false;
                level8=true;
                Debug.Log("level 8 ="+ level8);
                SceneManager.LoadScene("LabirinNM");
                playerMemorys.initialValue = new Vector2(-20.0f, 1.24f);
            } else {
                FindObjectOfType<NotificationManager>().StartNotification(notifikasigturu);
                Invoke("hapusnotif", 2f);
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("huhueg");
            Debug.Log("status = " + triggerPercakapandokter.sdhlvl1);
            FindObjectOfType<NotificationManager>().StartNotification(notifikasituru);
            sdhnotif=true;
        }
    }

    void hapusnotif()
    {
        FindObjectOfType<NotificationManager>().HideNotification();
    }
}
