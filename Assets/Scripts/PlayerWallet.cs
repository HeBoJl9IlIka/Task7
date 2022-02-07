using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWallet : MonoBehaviour
{
    public int Money { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin Coin))
        {
            Money++;
            Destroy(Coin.gameObject);
        }
    }
}
