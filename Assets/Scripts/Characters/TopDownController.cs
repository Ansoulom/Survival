﻿using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class TopDownController : MonoBehaviour
{
    private Vector2 _input;

    private Vector2 _velocity;
    public float MaxSpeed = 5f;
    public Vector2 Direction { get; private set; }


    public Vector2 Input
    {
        get { return _input; }
        set
        {
            _input = value.normalized;
            if (_input.magnitude > 0f) Direction = _input;
        }
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
        var sprite = GetComponent<SpriteRenderer>();
        if (_velocity.x > 0f)
            sprite.flipX = false;
        else if (_velocity.x < 0f)
            sprite.flipX = true;
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