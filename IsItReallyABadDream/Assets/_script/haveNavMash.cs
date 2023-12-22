using UnityEngine;
using UnityEngine.AI;

public class CheckNavMeshAgent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        NavMeshAgent agent = other.GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            // If the object has a NavMeshAgent component
            Debug.Log("Object has a NavMeshAgent component.");
            // You can access the NavMeshAgent properties or perform actions here
        }
        else
        {
            // If the object does not have a NavMeshAgent component
            Debug.Log("Object does not have a NavMeshAgent component.");
        }
    }
}
