using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] protected PlayerController playerController;

    protected void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnTriggerStay(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            playerController.currentHealth -= 20;
       }
    }
}
