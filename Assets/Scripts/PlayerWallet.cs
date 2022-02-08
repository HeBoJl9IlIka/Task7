using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWallet : MonoBehaviour
{
    public int Money { get; private set; }

    public void AddMoney()
    {
        ++Money;
    }
}
