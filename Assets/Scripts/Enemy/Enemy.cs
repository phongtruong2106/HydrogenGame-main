using System.Collections;
using System.Collections.Generic;
using Photon.Realtime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected PlayerController objPlayer;
    [SerializeField]protected NavMeshAgent navMeshAgent;
    [SerializeField] protected PlayerController playerController;

    private void Start() {
        navMeshAgent = GetComponent<NavMeshAgent>();
        objPlayer = FindAnyObjectByType<PlayerController>();
        playerController = FindAnyObjectByType<PlayerController>();
    }

    protected virtual void Update()
    {     
        navMeshAgent.SetDestination(objPlayer.transform.position);
    }
}
