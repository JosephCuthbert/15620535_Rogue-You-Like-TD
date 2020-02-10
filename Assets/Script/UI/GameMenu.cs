using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Options()
    {
        Debug.Log("OPTIONS");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
