using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    private TowerBlueprint towerToBuild;
    public GameObject standardTowerPrefab;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public void SelectTowerToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
    }

    public bool CanBuild { get { return towerToBuild != null; } }    
    public bool HasMoney { get { return Player.Money >= towerToBuild.cost; } }    


    public void BuildTowerOn(Node node)
    {
        if (Player.Money < towerToBuild.cost)
        {
            Debug.Log("Not enough gold!");
            return; 
        }
        Player.Money -= towerToBuild.cost;

        GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.tower = tower;
        Debug.Log("Tower built! Gold left: " + Player.Money);

    }

}
