using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject NextLevelButton;

    private void Start()
    {
        NextLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (WaveSpawner.StartText == 10)
        {
            NextLevelButton.SetActive(true);
        }
    }
}
