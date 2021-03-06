using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRaisingCoin : MonoBehaviour
{
    [SerializeField] private UnityEvent _taken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin Coin))
        {
            _taken?.Invoke();
            Destroy(Coin.gameObject);
        }
    }
}
