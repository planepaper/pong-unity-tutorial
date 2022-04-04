using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody2D;
    protected float _moveSpeed = 10f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidbody2D.position = new Vector2(_rigidbody2D.position.x, 0f);
        _rigidbody2D.velocity = Vector2.zero;
    }
}
