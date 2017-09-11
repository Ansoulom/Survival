using System.Collections.Generic;
using UnityEngine;

public abstract class Craftable : ScriptableObject
{
    public int WoodCost, StoneCost, IronCost, WaterCost;
    public Sprite Icon;
    public string Name;

    public bool CanCraft(Inventory inv)
    {
        return inv.Contains("Wood", WoodCost) && inv.Contains("Stone", StoneCost) &&
               inv.Contains("Iron", IronCost) && inv.Contains("Water", WaterCost);
    }


    public void Craft(Inventory inv)
    {
        inv.RemoveResource("Wood", WoodCost);
        inv.RemoveResource("Stone", StoneCost);
        inv.RemoveResource("Iron", IronCost);
        inv.RemoveResource("Water", WaterCost);

        Create(inv);
    }


    protected abstract void Create(Inventory inv);
}