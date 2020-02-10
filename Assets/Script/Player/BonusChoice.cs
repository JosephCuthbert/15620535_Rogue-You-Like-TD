using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusChoice : MonoBehaviour
{
    //Allow to place on path

    public TurretBlueprint Cola;
    public TurretBlueprint Cherry;
    BuildManager buildManager;

    public void SelectBonusCola()
    {
        buildManager.SelectTurretToBuild(Cola);
    }
    public void SelectBonusCherry()
    {
        buildManager.SelectTurretToBuild(Cherry);
    }

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectCola()
    {
        Debug.Log("Cola Bonus Selected");
        buildManager.SelectTurretToBuild(Cola);
    }
    public void SelectCherry()
    {
        Debug.Log("Cherry Bonus Selected");
        buildManager.SelectTurretToBuild(Cherry);
    }

}
