using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPos;
    public VectorValue playerMemory;

    // LaciController controller;

    public void OnTriggerEnter2D(Collider2D other)
    {
        // bool trigger = controller.IsOpen;
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerMemory.initialValue = playerPos;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
