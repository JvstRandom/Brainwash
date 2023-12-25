using UnityEngine;
using UnityEngine.UI;

public class NotificationManager : MonoBehaviour
{
    public Text notificationText;
    public Animator notificationAnimator;
    private string notificationContent;

    // Method to start a notification
    public void StartNotification(string content)
    {
        notificationContent = content;
        notificationAnimator.SetBool("IsOpen", true);
        notificationText.text = notificationContent;
    }

    // Method to hide/close the notification
    public void HideNotification()
    {
        notificationAnimator.SetBool("IsOpen", false);
        notificationContent = "";
        notificationText.text = "";
    }
}
