using UnityEngine;

public class Shop : MonoBehaviour {

	public TowerBlueprint standardTower;
	BuildManager buildManager;

	void Start() {
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTower() {
		Debug.Log("Standard Tower Purchased!");
		buildManager.SelectTowerToBuild(standardTower);
	}	



}