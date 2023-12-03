using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    Text CodeText;
    string KodeBrankas = "";

    // Update is called once per frame
    void Update()
    {
        CodeText.text = KodeBrankas;

        if (KodeBrankas == "7315") {
            PlayerMovement.isSafeOpened = true;
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
