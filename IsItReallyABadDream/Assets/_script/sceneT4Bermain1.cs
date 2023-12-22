using UnityEngine;
using UnityEngine.UI;

public class SceneT4Bermain1 : MonoBehaviour
{
    public static bool sceneMulai;
    public Text dialogTexts;
    public string[] dialogs;
    public Text namaCharacter;
    public string[] namaYgNgomong;
    public GameObject dialogBox;

    private int currentIndex = 0;
    private bool isDialogActive = false;
    private bool dialogSdh = false;

    void Start()
    {
        dialogBox.SetActive(false);
        sceneMulai = false;
    }

    void Update()
    {
        if (isDialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextDialog();
            
        }

        if(faithnhopeCutsceneTrigger.FaithnHopeHilang)
        {
            sceneMulai = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("huhu");
            if (!sceneMulai && MainMenu.level1 && !dialogSdh)
            {
                Debug.Log("huha");
                sceneMulai = true;
                StartDialog();
            }
        }
    }

    void StartDialog()
    {
        dialogBox.SetActive(true);
        isDialogActive = true;
        currentIndex = 0;
        dialogTexts.text = dialogs[currentIndex];
        namaCharacter.text = namaYgNgomong[currentIndex];
    }

    void DisplayNextDialog()
    {
        currentIndex++;

        if (currentIndex < dialogs.Length)
        {
            dialogTexts.text = dialogs[currentIndex];
            namaCharacter.text = namaYgNgomong[currentIndex];
        }
        else
        {
            dialogSdh = true;
            EndDialog();
        }
    }

    void EndDialog()
    {
        dialogBox.SetActive(false);
        isDialogActive = false;
        currentIndex = 0;

        // Additional logic after the dialog ends
    }
}
