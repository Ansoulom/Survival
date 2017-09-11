using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<string, int> Resources;
    public List<Weapon> Weapons;

    // Use this for initialization
    private void Start()
    {
        Weapons = new List<Weapon>();
        Resources = new Dictionary<string, int>();
    }

    public void AddResource(string resource, int count = 1)
    {
        if (!Resources.ContainsKey(resource))
            Resources.Add(resource, count);
        else
            Resources[resource] += count;

        DestroyObject(gameObject);
    }


    public bool Contains(string material, int count)
    {
        if (!Resources.ContainsKey(material)) return false;
        return Resources[material] >= count;
    }


    public void RemoveResource(string material, int count)
    {
        if (!Contains(material, count)) throw new ArgumentException("materials don't exist");

        Resources[material] -= count;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}