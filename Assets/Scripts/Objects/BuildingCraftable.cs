using UnityEngine;

[CreateAssetMenu(menuName = "Craftable/Building")]
public class BuildingCraftable : Craftable
{
    public GameObject Building;

    protected override void Create(Inventory inv)
    {
        Building.SetActive(true);
    }
}