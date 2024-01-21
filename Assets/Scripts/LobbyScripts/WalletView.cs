using System;
using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _amountMoney;
    [SerializeField] private Wallet _wallet;

    private void Awake()
    {
        _wallet.MoneyQuantityHandler += UpdateAmountMoney;
    }

    private void UpdateAmountMoney(float amountMoney)
    {
        _amountMoney.text = amountMoney.ToString();
    }

    private void OnDestroy()
    {
        _wallet.MoneyQuantityHandler -= UpdateAmountMoney;
    }
}
