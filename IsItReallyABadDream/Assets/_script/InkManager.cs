using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class InkManager : MonoBehaviour
{
    public TextAsset inkJSONAsset;
    private Story story;
    public Text textDisplay;

    void Start()
    {
        story = new Story(inkJSONAsset.text);
        StartCoroutine(StartStory());
    }

    IEnumerator StartStory()
    {
        while (story.canContinue)
        {
            string text = story.Continue();
            // Tampilkan teks di layar atau lakukan tindakan tertentu sesuai kebutuhan Anda
            textDisplay.text = text;

            // Periksa apakah ada pilihan
            if (story.currentChoices.Count > 0)
            {
                // Tampilkan pilihan pemain di layar atau lakukan tindakan tertentu
                for (int i = 0; i < story.currentChoices.Count; i++)
                {
                    Choice choice = story.currentChoices[i];
                    // Misalnya, tampilkan pilihan pada tombol UI
                    // (pastikan Anda menyesuaikan sesuai dengan tata letak dan input permainan Anda)
                    // ...

                    // Tanggapi pemilihan pemain
                    // Jika pemain memilih pilihan pertama, jalankan fungsi dengan label yang sesuai
                    // (Anda perlu menyesuaikan label berdasarkan cerita Anda)
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                    {
                        story.ChooseChoiceIndex(0);
                        StartCoroutine(StartStory());
                    }
                    // Lakukan hal serupa untuk pilihan lainnya
                    // ...
                }
            }
            else
            {
                // Cerita selesai atau menunggu input pemain untuk membuat pilihan
            }

            yield return null;

        }
        // Cerita selesai atau menunggu input pemain untuk membuat pilihan
    }
}
