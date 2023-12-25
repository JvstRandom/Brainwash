using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kunciRR : MonoBehaviour
{
    public GameObject sceneRR;
    public string warn;
    // Start is called before the first frame update
    void Start()
    {
        sceneRR.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerManager.haveKey)
        {
            sceneRR.SetActive(true);
        } 
        if(Input.GetKeyDown(KeyCode.Space) && FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen"))
        {
            FindObjectOfType<NotificationManager>().HideNotification();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("huhueg");
            if (!PlayerManager.haveKey)
            {
                Debug.Log("huha");
                FindObjectOfType<NotificationManager>().StartNotification(warn);
            }
        }
    }
}
