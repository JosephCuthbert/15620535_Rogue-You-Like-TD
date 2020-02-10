using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    public GameObject turret;

    public Vector3 positionOffset;

    public Color NotEnoughMoney;

    public Color hoverColor;

    private Renderer rend;

    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    BuildManager buildManager;

    void OnMouseDown()
    {

        if (!buildManager.CanBuild)
        {
            return;
        }

        if (turret != null)
        {
            Debug.Log("Can't Build There!");
                return;
        }

        buildManager.BuildTurretOn(this);
    }

    void OnMouseEnter()
    {
        
        if (!buildManager.CanBuild)
        {
            return;
        }


        if (buildManager.HasMoney)
        {
            GetComponent<Renderer>().material.color = hoverColor;
        }
        else
        {
            GetComponent<Renderer>().material.color = NotEnoughMoney;
        }
   
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;    
    }

}
