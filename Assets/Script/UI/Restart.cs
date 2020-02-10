using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{

    public GameObject GameMenu;
    public GameObject Quit;

    private void Start()
    {
        GameMenu.SetActive(false);
        Quit.SetActive(true);
    }

    public void GameMenuvoid()
    {
        GameMenu.SetActive(true);
        Quit.SetActive(false);  
        Time.timeScale = 0;  
    }

}
