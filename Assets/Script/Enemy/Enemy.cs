using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedNum = 4.0f;
    public static float speed;
    private Waypoint wPoint;
    private Transform target;
    private int waypointIndex = 0;

    public int value = 10;

    void Start()
    {
       
        target = Waypoint.points[0];
        //wPoint = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoint>();
        speed = speedNum;
        
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

        
    }

    void GetNextWayPoint()
    {
        if(waypointIndex >= Waypoint.points.Length - 1)
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
        PlayerStats.Money -= 10;
        Destroy(gameObject);
    }
}
