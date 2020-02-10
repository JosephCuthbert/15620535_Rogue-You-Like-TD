using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Quit;

    public void Level1Choice()
    {
        SceneManager.LoadScene(2);
    }
    public void Level2Choice()
    {
        SceneManager.LoadScene(3);
    }
    public void Level3Choice()
    {
        SceneManager.LoadScene(4);
    }
    public void Level4Choice()
    {
        SceneManager.LoadScene(5);
    }
    public void Level5Choice()
    {
        SceneManager.LoadScene(6);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }






}
