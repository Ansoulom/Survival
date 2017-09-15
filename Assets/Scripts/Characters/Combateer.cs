using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DeathComponent))]
public class Combateer : MonoBehaviour
{
    public int MaxHealth = 5;
    public LayerMask EnemyLayers;
    public float AttackRange = 1f;
    public float AttackWidth = 0.25f;

    private int _health;

	// Use this for initialization
	private void Start ()
    {
        _health = MaxHealth;
    }


    public void Attack(int damage)
    {
        // TODO: Add animation here
        var direction = GetComponent<TopDownController>().Direction;
        var collisions =
            Physics2D.OverlapBoxAll(
                new Vector2(transform.position.x, transform.position.y) + direction * (AttackRange / 2),
                new Vector2(AttackWidth, AttackRange), Vector2.SignedAngle(Vector2.up, direction), EnemyLayers);
        foreach (var collision in collisions)
        {
            var target = collision.GetComponent<Combateer>();
            if (target)
            {
                target.TakeDamage(damage);
            }
        }
    }


    private void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Kill();
        }
    }


    private void Kill()
    {
        GetComponent<DeathComponent>().Kill();
    }
}
