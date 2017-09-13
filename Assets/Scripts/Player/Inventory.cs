using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public InventorySlot[] Items;
    public int Wood, Stone, Iron;


    private void Awake()
    {
        Items = new InventorySlot[7]; // TODO: Magic number
        for (var i = 0; i < Items.Length; ++i)
        {
            Items[i] = new InventorySlot();
        }
    }


    private void Start()
    {
        
    }

    public void AddResource(string resource, int count = 1)
    {
        switch (resource)
        {
            case "Wood":
                Wood += count;
                break;
            case "Stone":
                Stone += count;
                break;
            case "Iron":
                Iron += count;
                break;
        }
    }


    public int GetResource(string resource)
    {
        switch (resource)
        {
            case "Wood":
                return Wood;
            case "Stone":
                return Stone;
            case "Iron":
                return Iron;
            default:
                throw new ArgumentException(resource + " is not valid.");
        }
    }


    public bool Contains(string material, int count)
    {
        switch (material)
        {
            case "Wood":
                return Wood >= count;
            case "Stone":
                return Stone >= count;
            case "Iron":
                return Iron >= count;
            default:
                return false;
        }
    }


    public void RemoveResource(string material, int count)
    {
        switch (material)
        {
            case "Wood":
                Wood -= count;
                break;
            case "Stone":
                Stone -= count;
                break;
            case "Iron":
                Iron -= count;
                break;
        }
    }


    public void AddItem(UsableItem item)
    {
        foreach (var slot in Items)
        {
            if (slot.Item == null)
            {
                slot.Item = item;
                return;
            }
        }
    }
}