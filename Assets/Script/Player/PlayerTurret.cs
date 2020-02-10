using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurret : MonoBehaviour
{
    public float fireRate = 1f;
    public float fireCountDown = 0f;
    private Transform target;
    public float range = 15f;
    public string enemyTag = "Enemy";
    public int health = 20;
    public static int healthNum;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public static float Rangenum;
    //public Transform partToRotate;

   

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f,0.5f);
        healthNum = health;
        Rangenum = fireCountDown;
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies) {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if(nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;

        }

        if(fireCountDown <= 0f)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }
        fireCountDown -= Time.deltaTime;

        if(healthNum == 0)
        {
            Destroy(gameObject);
        }
    }


    void Shoot()
    {
        GameObject bulletGO =(GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if(bullet != null)
        {
            bullet.Chase(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);    
    }


    
}
