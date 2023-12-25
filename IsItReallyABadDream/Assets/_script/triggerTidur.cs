using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerTidur : MonoBehaviour
{
    public string notifikasituru;
    public string sceneToLoads;
    public Vector2 playerPoss;
    public VectorValue playerMemorys;
    private bool sdhnotif =false;
    public static bool level2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) && sdhnotif)
        {
            playerMemorys.initialValue = playerPoss;
            SceneManager.LoadScene(sceneToLoads);
            if(triggerPercakapandokter.sdhlvl1){
                MainMenu.level1 = false;
                triggerPercakapandokter.sdhlvl1 = false;
                level2 = true;
            }
            FindObjectOfType<NotificationManager>().HideNotification();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && (triggerPercakapandokter.sdhlvl1))
        {
            Debug.Log("huhueg");
            FindObjectOfType<NotificationManager>().StartNotification(notifikasituru);
            sdhnotif=true;
        }
    }
}
