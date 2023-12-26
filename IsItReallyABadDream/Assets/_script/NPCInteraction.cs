// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class NPCInteraction : MonoBehaviour
// {
//     public float interactionDistance = 3f;
//     public GameObject dialogBUtton;
//     public TextAsset inkJsonAsset; //file ink untuk dialog

//     // Update is called once per frame
//     void Update()
//     {
//         float distanceToPlayer = Vector3.Distance(transform.position, PlayerController.instance.transform.position);

//         if(distanceToPlayer <= interactionDistance)
//         {
//             dialogBUtton.SetActive(true);

//             if(Input.GetKeyDown(KeyCode.E))
//             {
//                 DialogManager.instance.StartInkDialog(inkJsonAsset);
//             }
//         }
//         else
//         {
//             dialogBUtton.SetActive(false);
//         }
//     }
// }
