using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<UsableItem> Items;
    public int Wood, Stone, Iron;


    // Use this for initialization
    private void Start()
    {
        Items = new List<UsableItem>();
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
}