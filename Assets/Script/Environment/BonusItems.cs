using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItems : MonoBehaviour
{
    public static GameObject Cherries;
    public string enemyTag = "Enemy";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Debug.Log("Slow");
            Enemy.speed = 2.0f;
        }
    }
    private void OnTriggerStay2D()
    {
        Enemy.speed = 2.0f;
    }
    private void OnTriggerExit2D()
    {
       
            Debug.Log("normal");
            Enemy.speed = 4.0f;
    
       
    }
   



}
