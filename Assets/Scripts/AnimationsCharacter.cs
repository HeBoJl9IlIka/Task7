using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CharacterControl))]
public class AnimationsCharacter : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    private CharacterControl _controlCharacter;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _controlCharacter = GetComponent<CharacterControl>();
    }

    private void Update()
    {
        if (_rigidbody2D.velocity.x > 0)
        {
            _spriteRenderer.flipX = false;
            _animator.SetFloat("Speed", _rigidbody2D.velocity.x);
        }
        else if(_rigidbody2D.velocity.x < 0)
        {
            _spriteRenderer.flipX = true;
           _animator.SetFloat("Speed", _rigidbody2D.velocity.x * -1);
        }

        if (_controlCharacter.IsOnGround)
        {
            _animator.SetFloat("Flight", 0);
        }
        else
        {
            _animator.SetFloat("Flight", _rigidbody2D.velocity.y);
        }
    }
}
