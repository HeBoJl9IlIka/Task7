using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private PlayerWallet _playerWallet;

    private void Update()
    {
        _text.text = "Монет: " + _playerWallet.Money;
    }
}
