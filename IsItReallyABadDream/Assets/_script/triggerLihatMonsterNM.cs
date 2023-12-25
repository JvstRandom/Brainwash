using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerLihatMonsterNM : MonoBehaviour
{
    public Image gambarMonsterNM;
    public dialog kaget;
    private bool sdhjumpscare=false;
    // Start is called before the first frame update
    void Start()
    {
        gambarMonsterNM.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && triggerTidur.level2 && sdhjumpscare)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && triggerTidur.level2 && !sdhjumpscare)
        {
            gambarMonsterNM.gameObject.SetActive(true);
            sdhjumpscare=true;
        }
    } 
}
