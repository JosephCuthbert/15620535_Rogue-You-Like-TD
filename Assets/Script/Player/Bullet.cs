using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 10f;

    public void Chase(Transform _target)
    {

        target = _target;
    }

    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position = transform.position;
        float distanceThisFram = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFram)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFram, Space.World);
    }

    void HitTarget()
    {

        Destroy(gameObject);
    }
}
