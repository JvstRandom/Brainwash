using UnityEngine;

public class brankasController : MonoBehaviour
{

    [SerializeField]
    GameObject CodePanel;

    public static bool isSafeOpened = false;

    [SerializeField]
    GameObject MiniGamePanel;

    public static bool isGotRightPotion = false;

    // Start is called before the first frame update
    void Start()
    {
        CodePanel.SetActive (false);
        MiniGamePanel.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSafeOpened) {
            CodePanel.SetActive (false);
        }

        if (isGotRightPotion) {
            MiniGamePanel.SetActive (false);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.CompareTag("brankas") && !isSafeOpened && TimerScript.TimerOn) {
            Debug.Log("Player is in range");
            CodePanel.SetActive (true);
        }

        if(col.gameObject.CompareTag("MiniGame") && !isGotRightPotion && TimerScript.TimerOn) {
            Debug.Log("Player is in range");
            MiniGamePanel.SetActive (true);
        }
    }

    void OnTriggerExit2D(Collider2D col) {
        if(col.gameObject.CompareTag("brankas")) {
            CodePanel.SetActive (false);
        }

        if(col.gameObject.CompareTag("MiniGame")) {
            MiniGamePanel.SetActive (false);
        }
    }
}
