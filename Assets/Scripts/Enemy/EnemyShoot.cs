using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : Enemy
{
    [SerializeField] protected float timer = 5;
    private float bulletTime;
    [SerializeField] protected GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;

    protected  void FixedUpdate()
    {
        this.ShootAtPlayer();   
    }
    protected virtual void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;
        if(bulletTime > 0) return;
        bulletTime = timer;
        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 6f);

    }
}
