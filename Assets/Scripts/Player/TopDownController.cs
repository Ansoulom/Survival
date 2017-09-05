using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TopDownController : MonoBehaviour
{
    private Vector2 _input;

    private Vector2 _velocity;
    public float MaxSpeed = 5f;


    public Vector2 Input
    {
        get { return _input; }
        set { _input = value.normalized; }
    }


    // Use this for initialization
    private void Start()
    {
        _velocity = Vector2.zero;
    }


    // Update is called once per frame
    private void Update()
    {
        _velocity = _input * MaxSpeed;
    }


    private void FixedUpdate()
    {
        Move();
        GetComponent<Rigidbody2D>().position = transform.position;
    }


    private void Move()
    {
        transform.position += new Vector3(_velocity.x, _velocity.y, 0f) * Time.deltaTime;
    }
}