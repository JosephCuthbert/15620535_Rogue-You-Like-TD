using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;
    public Transform Bossprefab;
    public static int waveNumber = 0;
    public Transform spawnPoint;
    public GameObject NextRoundText;
    public GameObject NoNextRound;
    public static int StartText;
    public int rounds = 0;

    void Start()
    {
 
        StartText = rounds;
    }


    void UpdateRound()
    {
        NoNextRound.SetActive(false);
    }

    public void NextRound()
    {
    
        NoNextRound.SetActive(true);
        waveNumber += 5;
        StartCoroutine(WaitThreeSeconds());

        if (rounds == 5)
        {
            Enemy.speed = 5f;

            for (int i = 0; i < 2; i++)
            {
                Instantiate(Bossprefab, spawnPoint.position, spawnPoint.rotation);
            }
        }
        
    }


   
    IEnumerator WaitThreeSeconds()
    {
        
        StartText += 1;
        yield return new WaitForSeconds(5.0f);

        StartCoroutine(SpawnWave());
        
        IEnumerator SpawnWave()
        {
           
            for (int i = 0; i < waveNumber; i++)
            {
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
               

                yield return new WaitForSeconds(0.9f);
            }
            UpdateRound();

        }
    }


    

}
