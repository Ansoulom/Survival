using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieInput : MonoBehaviour
{
    private Combateer _player;

	// Use this for initialization
    private void Start ()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Combateer>();
    }
	
	// Update is called once per frame
    private void Update ()
    {
		
	}
}
