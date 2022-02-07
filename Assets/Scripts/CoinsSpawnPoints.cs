using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawnPoints : MonoBehaviour
{
    [SerializeField] private GameObject _prefabCoin;

    private Transform[] _points;

    private void Awake()
    {
        _points = GetComponentsInChildren<Transform>();
    }

    private void Start()
    {
        for (int i = 1; i < _points.Length; i++)
        {
            Instantiate(_prefabCoin, _points[i]);
        }
    }
}
