using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0f)
        {
            if (ball.position.y > transform.position.y)
            {
                _rigidbody2D.AddForce(Vector2.up * _moveSpeed);
            }
            else if (ball.position.y < transform.position.y)
            {
                _rigidbody2D.AddForce(Vector2.down * _moveSpeed);
            }
        }
        else
        {
            if (transform.position.y > 0f)
            {
                _rigidbody2D.AddForce(Vector2.down * _moveSpeed);
            }
            else if (transform.position.y < 0f)
            {
                _rigidbody2D.AddForce(Vector2.up * _moveSpeed);
            }
        }
    }
}
