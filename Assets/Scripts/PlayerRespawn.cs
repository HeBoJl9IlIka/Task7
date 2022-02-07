using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform _pointSpawn;

    private Transform _transformPlayer;

    private void Awake()
    {
        _transformPlayer = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<EnemyPatrolling>(out EnemyPatrolling enemy) || collision.TryGetComponent<Border>(out Border border))
        {
            _transformPlayer.position = _pointSpawn.position;
        }
    }
}
