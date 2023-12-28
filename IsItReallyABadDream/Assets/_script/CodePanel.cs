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
            Debug.Log("punya kunci = " + PlayerManager.haveKeyLabirin );
            FindObjectOfType<NotificationManager>().StartNotification(notifikasiLabirin);
            Invoke("hilang", 3f);
        }

        if (KodeBrankas.Length >= 4) {
            KodeBrankas = "";
        }
    }

    void hilang()
    {
        FindObjectOfType<NotificationManager>().HideNotification();
    }

    public void AddNum(string num) {
        KodeBrankas += num;
    }

    public void hapus(){
        KodeBrankas = "";
    }
}
