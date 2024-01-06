using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float TimeLeft;
    public GameObject Timer;
    public static bool TimerOn = false;
    public static bool sudahTimer;

    public Text TimerTxt;
   
    void Start()
    {
        
    }

    void Update()
    {
        if(triggerSleseLevel6.level7)
        {
            DontDestroyOnLoad(Timer);
        }else if (!triggerSleseLevel6.level7 && !bukuZach.level5)
        {
            // Destroy(Timer);
            Timer.SetActive(false);
        }
        if(TimerOn)
        {
            Timer.SetActive(true);
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
                sudahTimer = true;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}