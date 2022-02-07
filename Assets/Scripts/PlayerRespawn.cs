using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform _pointSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<EnemyPatrolling>(out EnemyPatrolling enemy) || collision.TryGetComponent<Border>(out Border border))
        {
            transform.position = _pointSpawn.position;
        }
    }
}
