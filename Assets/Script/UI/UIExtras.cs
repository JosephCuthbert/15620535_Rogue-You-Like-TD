using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIExtras : MonoBehaviour
{
    public GameObject rngNumberBad;
    public GameObject rngNumberGood;
    public GameObject moneyPopup;


    void Start()
    {
        rngNumberBad.SetActive(false);
        rngNumberGood.SetActive(false);
        moneyPopup.SetActive(false);
    }

    public void UnlimitedMode()
    {
        WaveSpawner.waveNumber += 100;
    }
    public void ExtraMoney()
    {
        PlayerStats.Money += 300;
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void RNG()
    {
        if (PlayerStats.Money >= 100)
        {
            moneyPopup.SetActive(true);
            PlayerStats.Money -= 100;
            StartCoroutine("WaitForTime");
        }
       
    }
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(3);
        moneyPopup.SetActive(false);    
        RandomCalc();
    }
    public void RandomCalc()
    {
        int rngNumber = Random.Range(1, 100);
        Debug.Log(rngNumber);
        if (rngNumber < 50)
        {
            Enemy.speed += 5f;
            rngNumberBad.SetActive(true);
            StartCoroutine("WaitForSec");
        }
        else
        {
            PlayerStats.Money += 150;
            rngNumberGood.SetActive(true);
            
            StartCoroutine("WaitForSec");
        }
       
    }


    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        rngNumberGood.SetActive(false);
        rngNumberBad.SetActive(false);
       
    }
}
   
