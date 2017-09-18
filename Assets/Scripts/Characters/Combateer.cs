using UnityEngine;

[RequireComponent(typeof(DeathComponent))]
public class Combateer : MonoBehaviour
{
    public float AttackRange = 1f;
    public float AttackWidth = 0.25f;
    public LayerMask EnemyLayers;

    public int Health;
    public int MaxHealth = 5;


    // Use this for initialization
    private void Start()
    {
        Health = MaxHealth;
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
                target.TakeDamage(damage);
        }
    }


    private void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
            Kill();
    }


    private void Kill()
    {
        GetComponent<DeathComponent>().Kill();
    }
}