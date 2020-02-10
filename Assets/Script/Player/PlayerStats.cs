using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 180;
    public GameObject GameOverText;
    public GameObject GameOverLay;
    public GameObject GameMenu;
    public static int Lives;
    public int startLives = 100;
   
  
    void Start()
    {
        Money = startMoney;
        Lives = startLives;
        GameOverText.SetActive(false);
        GameOverLay.SetActive(false);
        GameMenu.SetActive(false);
    }
    void Update()
    {



        if(Lives == 0)
        {
            GameOverText.SetActive(true);
            GameOverLay.SetActive(true);
            GameMenu.SetActive(true);
            Time.timeScale = 0;
            
        }
    }



}
