using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<string, int> Resources;
    public List<Weapon> Weapons;

	// Use this for initialization
	private void Start ()
    {
        Weapons = new List<Weapon>();
        Resources = new Dictionary<string, int>();
	}

    public void AddResource(string resource, int count = 1)
    {
        if (!Resources.ContainsKey(resource))
        {
            Resources.Add(resource, count);
        }
        else
        {
            Resources[resource] += count;
        }

        DestroyObject(gameObject);
    }
	
	// Update is called once per frame
	private void Update ()
    {
		
	}
}
