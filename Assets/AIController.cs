using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private GameObject destination;
    private NavMeshAgent agent;

    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Destino");
        if (destination == null)
        {
            Debug.LogError("Destination object with tag 'Destino' not found.");
            return;
        }

        agent = GetComponent<NavMeshAgent>();
        if (agent == null)
        {
            Debug.LogError("NavMeshAgent component not found on this GameObject.");
            return;
        }

        agent.SetDestination(destination.transform.position);
        Debug.Log("Setting destination to: " + destination.transform.position);
    }

    void Update()
    {
        if (agent.pathPending || agent.remainingDistance > agent.stoppingDistance) return;

        // Here you can add more logic if you want the robot to do something upon reaching the destination.
        Debug.Log("Reached destination");
    }
}
