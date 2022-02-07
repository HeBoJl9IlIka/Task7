using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyPatrolling))]
[RequireComponent(typeof(SpriteRenderer))]
public class AnimationsEnemy : MonoBehaviour
{
    private EnemyPatrolling _enemyPatrolling;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _enemyPatrolling = GetComponent<EnemyPatrolling>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(_enemyPatrolling.IsMoveRight)
        {
            _spriteRenderer.flipX = false;
        }
        else
        {
            _spriteRenderer.flipX = true;
        }
    }
}
