using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{

    public int health;
    public static int healthdam;
    public int damage;
    public static int damagedam;
    public float speedNum = 4.0f;
    public static float speed;
    private Waypoint wPoint;
    private Transform target;
    private int waypointIndex = 0;
    public int value = 20;

    void Start()
    {
        target = Waypoint.points[0];
    }

    void OnBecameInvisible()
    {
        PlayerStats.Money += value;
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);



        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {

            GetNextWayPoint();

        }

        var collider =  GetComponent<Collider2D>();
        if (collider.GetComponent<Collider2D>().tag == "Player")
        {
            PlayerTurret.Rangenum += 1.0f;
        }
    }

    void GetNextWayPoint()
    {
        if (waypointIndex >= Waypoint.points.Length - 1)
        {
            EndPath();
            return;
        }

        waypointIndex++;
        target = Waypoint.points[waypointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        PlayerStats.Money -= 20;
        Destroy(gameObject);
    }
}
