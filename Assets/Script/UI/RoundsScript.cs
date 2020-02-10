using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoundsScript : MonoBehaviour
{
    public Text roundText;

    private void Update()
    {
        roundText.text = WaveSpawner.StartText.ToString();
    }

}
