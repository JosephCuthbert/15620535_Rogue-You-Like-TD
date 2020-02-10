using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretChoice : MonoBehaviour
{
    public TurretBlueprint Turret;
    public TurretBlueprint AxeTurret;
   
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectMeleeTurret()
    {
        Debug.Log("Melee Turret Selected");
        buildManager.SelectTurretToBuild(Turret);

    }
    public void SelectAxeTurret()
    {
        Debug.Log("Ranked Turret Selected");
        buildManager.SelectTurretToBuild(AxeTurret);
    }
  


}
