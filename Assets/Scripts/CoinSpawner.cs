using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _template;

    private Transform[] _points;

    private void Awake()
    {
        _points = GetComponentsInChildren<Transform>();
    }

    private void Start()
    {
        for (int i = 1; i < _points.Length; i++)
        {
            Instantiate(_template, _points[i]);
        }
    }
}
