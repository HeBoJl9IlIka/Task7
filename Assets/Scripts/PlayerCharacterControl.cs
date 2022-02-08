using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCharacterControl : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _jumpForce;

    private bool _isOnGround;
    private Rigidbody2D _rigidbody2D;

    private bool _isMoves => Input.GetAxis("Horizontal") != 0;
    public bool IsOnGround => _isOnGround;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_isMoves)
        {
            _rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * _speed, _rigidbody2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space) && _isOnGround)
        {
            _rigidbody2D.AddForce(new Vector2(_rigidbody2D.velocity.x, _jumpForce));
            _isOnGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Ground>(out Ground ground))
        {
            _isOnGround = true;
        }
    }
}
