using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CharacterControl))]
public class AnimatorCharacter : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    private CharacterControl _controlCharacter;
    private const string _speed = "Speed";
    private const string _flight = "Flight";

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
            _animator.SetFloat(_speed, _rigidbody2D.velocity.x);
        }
        else if(_rigidbody2D.velocity.x < 0)
        {
            _spriteRenderer.flipX = true;
           _animator.SetFloat(_speed, _rigidbody2D.velocity.x * -1);
        }

        if (_controlCharacter.IsOnGround)
        {
            _animator.SetFloat(_flight, 0);
        }
        else
        {
            _animator.SetFloat(_flight, _rigidbody2D.velocity.y);
        }
    }
}