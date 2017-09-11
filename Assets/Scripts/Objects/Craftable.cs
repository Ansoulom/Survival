using System.Collections.Generic;
using UnityEngine;

public abstract class Craftable : ScriptableObject
{
    public KeyValuePair<string, int>[] Cost;

    public bool CanCraft(Inventory inv)
    {
        foreach (var pair in Cost)
            if (!inv.Contains(pair.Key, pair.Value))
                return false;
        return true;
    }


    public void Craft(Inventory inv)
    {
        foreach (var pair in Cost)
        {
            inv.RemoveResource(pair.Key, pair.Value);
        }

        Create(inv);
    }


    protected abstract void Create(Inventory inv);
}