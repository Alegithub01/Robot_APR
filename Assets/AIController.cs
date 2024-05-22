using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private GameObject destination;
    private NavMeshAgent agent;

    void Start(){
        destination = GameObject.FindGameObjectWithTag("Destino");
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destination.transform.position);
    }
} 