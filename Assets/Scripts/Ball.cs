using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200f;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        Vector2 initDirection;
        initDirection.x = Random.value < 0.5f ? -1.0f : 1.0f;
        initDirection.y = Random.value < 0.5f ? -1.0f : 1.0f;

        _rigidbody2D.AddForce(initDirection * speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody2D.AddForce(force);
    }
}
