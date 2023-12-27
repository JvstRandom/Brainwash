using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerLihatMonsterNM : MonoBehaviour
{
    public GameObject canvasgambar;
    public dialog kaget;
    private bool sdhjumpscare=false;
    private bool sdhdialog=false;
    // Start is called before the first frame update
    void Start()
    {
        canvasgambar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && triggerTidur.level2 && sdhjumpscare && !sdhdialog)
        {
            canvasgambar.SetActive(false);
            FindObjectOfType<DialogManager>().StartDialog(kaget);
        
            if(FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                FindObjectOfType<DialogManager>().DisplayNextSentences();
            }else if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen"))
            {
                sdhdialog=true;
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && triggerTidur.level2 && !sdhjumpscare)
        {
            canvasgambar.SetActive(true);
            sdhjumpscare=true;
        }
    } 
}
