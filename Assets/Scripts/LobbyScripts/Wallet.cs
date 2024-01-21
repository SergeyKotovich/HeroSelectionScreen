using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private float _amountMoney = 20000;
    public event Action<float> MoneyQuantityHandler;

    private void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        MoneyQuantityHandler?.Invoke(_amountMoney);
    }

    public bool BuyItem(float currentHeroPrice)
    {
        if (_amountMoney>= currentHeroPrice)
        {
            _amountMoney -= currentHeroPrice;
            MoneyQuantityHandler?.Invoke(_amountMoney);
            return true;
        }
        else
        {
            Debug.Log("Недостаточно денег для покупки");
            return false;
        }
    }
}
