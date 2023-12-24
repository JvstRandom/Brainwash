using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameTxt;
    public Text dialogTxt;
    public Image imageChara;
    public Animator animator;
    public static bool sdhdialog = false;
    public static bool sdgDialog = false;

    private Queue<string> sentences;
    private Queue<string> names;
    private Queue<Sprite> images;
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
        images = new Queue<Sprite>();
    }

    public void StartDialog(dialog percakapan)
    {
        sdgDialog = true;
        animator.SetBool("isOpen", true);
        sentences.Clear();
        names.Clear();
        images.Clear();

        foreach(string sentence in percakapan.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (string name in percakapan.name)
        {
            names.Enqueue(name);
        }

        foreach (Sprite image in percakapan.image)
        {
            images.Enqueue(image);
        }

        DisplayNextSentences();
    }

    public void DisplayNextSentences()
    {
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        string name = names.Dequeue();
        Sprite image = images.Dequeue();

        dialogTxt.text = sentence;
        nameTxt.text = name;
        imageChara.sprite = image;
        // string namachara = n
        Debug.Log(sentence);
    }

    void EndDialog()
    {
        sdgDialog = false;
        animator.SetBool("isOpen", false);
        sdhdialog = true;
    }
    
}


