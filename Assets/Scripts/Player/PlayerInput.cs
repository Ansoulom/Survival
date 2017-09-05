using UnityEngine;


[RequireComponent(typeof(TopDownController))]
public class PlayerInput : MonoBehaviour
{
    private TopDownController _controller;


    // Use this for initialization
    private void Start()
    {
        _controller = GetComponent<TopDownController>();
    }


    // Update is called once per frame
    private void Update()
    {
        _controller.Input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}