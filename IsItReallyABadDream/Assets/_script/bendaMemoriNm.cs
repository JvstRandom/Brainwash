using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bendaMemoriNm : MonoBehaviour
{
    public Sprite spriteBaru;
    public Material newMaterial;
    public dialog bendaMemoriNMdialog;
    private SpriteRenderer spriteRenderer;
    public static int jmlhNyentuhBendaMemoriNM = 0;
    public static bool sdhsemua=false;
    private bool ngomong = false;
    private bool increase=false;
    public static bool level3;
    public Vector2 playerPos;
    public VectorValue playerMemory;
    

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
                Debug.Log("jumlah memori=" + jmlhNyentuhBendaMemoriNM);
                increase=true;
            }
        }

        if(jmlhNyentuhBendaMemoriNM == 3)
        {
            sdhsemua=true;
            Debug.Log("jumlahsemua="+sdhsemua);
            FindObjectOfType<NotificationManager>().StartNotification("kamu sudah menemukan semua benda misi selesai");
            Invoke("pindahLvl", 2.3f);
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

    void pindahLvl()
    {
        FindObjectOfType<NotificationManager>().HideNotification();
                SceneManager.LoadScene("kamar1");
                jmlhNyentuhBendaMemoriNM--;
                level3=true;
    }
}
