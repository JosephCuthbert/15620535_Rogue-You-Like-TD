using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBonus : MonoBehaviour
{
    public GameObject Cherries;
    public string enemyTag = "Enemy";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Debug.Log("Stopped");
            StartCoroutine(FreezeTime());

        }

    }

    IEnumerator FreezeTime()
    {
        Enemy.speed = 0.0f;
        yield return new WaitForSeconds(2.0f);
        Enemy.speed = 4.0f;
    }
}
