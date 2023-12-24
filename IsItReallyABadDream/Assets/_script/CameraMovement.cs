using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameObject target;
    public float smooth;

    public Vector2 maxPos;
    public Vector2 minPos;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        if (target == null)
        {
            Debug.LogError("Target GameObject with tag Player not found!");
        }
    }

    private void FixedUpdate()
    {
        if(transform.position != target.transform.position)
        {
            Vector3 targetPos = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);

            targetPos.x = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPos.y, maxPos.y);

            transform.position = Vector3.Lerp(transform.position, targetPos, smooth);
        }
    }
}
