using UnityEngine;


namespace Player
{
    public class TopDownController : MonoBehaviour
    {
        private Vector2 _velocity;


        // Use this for initialization
        private void Start ()
        {
		    _velocity = Vector2.zero;
        }
	

        // Update is called once per frame
        private void Update ()
        {
		    Move();
        }


        private void Move()
        {
            transform.position += new Vector3(_velocity.x, _velocity.y, 0f);
        }
    }
}
