using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer rend;
    public Color hoverColor;
    public Color startColor;
    
    [Header("Optional")]
    public GameObject tower;
    public Vector3 postionOffset;
    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + postionOffset;
    }

    void OnMouseDown()
{
    if (!buildManager.CanBuild)
        return;

    if (tower != null)
    {
        Debug.Log("Can't build there!");
        return;
    }


        buildManager.BuildTowerOn(this);
    // GameObject towerToBuild = buildManager.GetTowerToBuild();  // Use the buildManager instance
    // tower = Instantiate(towerToBuild, transform.position + postionOffset, transform.rotation);
}

    void OnMouseEnter()
    {
        if(!buildManager.CanBuild)
            return;
        
        rend.material.color = hoverColor;
        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
