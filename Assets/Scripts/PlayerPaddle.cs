using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    private float moveSpeed = 10f;

    private void Update()
    {
        _direction.y = Input.GetAxis("Vertical") * moveSpeed;

    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _direction * Time.fixedDeltaTime);
    }
}