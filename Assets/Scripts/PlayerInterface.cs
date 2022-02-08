using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    [SerializeField] private Text _money;
    [SerializeField] private PlayerWallet _playerWallet;

    public void ShowInfo()
    {
        _money.text = "Монет: " + _playerWallet.Money;
    }
}
