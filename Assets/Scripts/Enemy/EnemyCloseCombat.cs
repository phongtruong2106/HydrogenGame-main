using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCloseCombat : Enemy
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            playerController.currentHealth -= 100;
       }
    }
}
