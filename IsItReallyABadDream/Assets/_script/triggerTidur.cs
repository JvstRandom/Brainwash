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
    public GameObject timer;
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
            }else if(SpriteChanger.sudahLevel3){
                bendaMemoriNm.level3 = false;
                level4 = true;
                Debug.Log("level 4 ="+ level4);
                SpriteChanger.sudahLevel3 = false;
                SceneManager.LoadScene("dapurNM");
                playerMemorys.initialValue = new Vector2(2.7f, -8.6f);
            } else if(triggerSudahSleseLevel5.sdhlvl5)
            {
                bukuZach.level5=false;
                TimerScript.sudahTimer = false;
                level6 = true;
                Debug.Log("level 6 ="+ level6);
                SceneManager.LoadScene("RuangRahasia NM");
                playerMemorys.initialValue = new Vector2(-7.05f, -4.03f);
            } else if(ngomongKeNPC.sdhLevel7)
            {
                triggerSleseLevel6.level7 = false;
                Destroy(timer);
                level8=true;
                Debug.Log("level 8 ="+ level8);
                SceneManager.LoadScene("Labirin NM");
                playerMemorys.initialValue = new Vector2(-20.0f, 2.41f);
            } else {
                FindObjectOfType<NotificationManager>().StartNotification(notifikasigturu);
                Invoke("hapusnotif", 2f);
                Debug.Log("percakapandokter = " + triggerPercakapandokter.sdhlvl1);
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
