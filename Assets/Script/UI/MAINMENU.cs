using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class MAINMENU : MonoBehaviour
{
   
    public GameObject PlayText;
    public GameObject LevelChoiceText;
    public GameObject Options;
    public GameObject Quit;

    public void Play()
    {
        SceneManager.LoadScene(2);
    }
    public void LevelChoice()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
