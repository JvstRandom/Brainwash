using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bendaMemoriNm : MonoBehaviour
{
    public Sprite spriteBaru;
    public Material newMaterial;
    public dialog bendaMemoriNMdialog;
    private SpriteRenderer spriteRenderer;
    public static int jmlhNyentuhBendaMemoriNM = 0;
    private bool ngomong = false;
    private bool increase=false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && ngomong)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentences();
            if(!FindObjectOfType<DialogManager>().animator.GetBool("isOpen") && !increase)
            {
                Debug.Log("end of convo");
                spriteRenderer.sprite = spriteBaru;
                spriteRenderer.material = newMaterial;
                jmlhNyentuhBendaMemoriNM++;
                increase=true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && triggerTidur.level2 && !ngomong)
        {
            FindObjectOfType<DialogManager>().StartDialog(bendaMemoriNMdialog);
            ngomong=true;
        }
    }
}
