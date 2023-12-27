using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    Text CodeText;
    string KodeBrankas = "";
    public string notifikasiLabirin;

    // Update is called once per frame
    void Update()
    {
        CodeText.text = KodeBrankas;

        if (KodeBrankas == "7315") {
            brankasController.isSafeOpened = true;
            PlayerManager.haveMapLabirin = true;
            PlayerManager.haveKeyLabirin = true;
            FindObjectOfType<NotificationManager>().StartNotification(notifikasiLabirin);
        }

        if(Input.GetKeyDown(KeyCode.Space) && FindObjectOfType<NotificationManager>().notificationAnimator.GetBool("IsOpen") && brankasController.isSafeOpened)
        {
            FindObjectOfType<NotificationManager>().HideNotification();
        }

        if (KodeBrankas.Length >= 4) {
            KodeBrankas = "";
        }
    }

    public void AddNum(string num) {
        KodeBrankas += num;
    }

    public void hapus(){
        KodeBrankas = "";
    }
}
