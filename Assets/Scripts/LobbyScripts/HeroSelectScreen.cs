using System;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;

public class HeroSelectScreen : MonoBehaviour
{
    [SerializeField] private HeroStatsView _heroStatsView;
    [SerializeField] private HeroLoader _heroLoader;
    [SerializeField] private GameObject _buyButton;
    [SerializeField] private GameObject _selectButton;
    
    public HeroSettings CurrentHero => _heroes[_currentHeroIndex];
    private Action<int> _onHeroSelected;
    private Wallet _wallet;
    private HeroSettings[] _heroes;
    private int _currentHeroIndex;

    public void Initialize(int currentHeroIndex, HeroSettings [] heroes, Wallet wallet,Action<int> onHeroSelected)
    {
        _heroes = heroes;
        _wallet = wallet;
        _onHeroSelected = onHeroSelected;
        Show(currentHeroIndex);
        var firstAvailableHero = heroes.FirstOrDefault(hero => hero.IsAvailable);
        _heroLoader.Show(firstAvailableHero ?? heroes.First());
    }

    private void Show(int currentHeroIndex)
    {
        _currentHeroIndex = currentHeroIndex;
        _heroLoader.Show(CurrentHero);
        _heroStatsView.Show(CurrentHero);
        UpdateButtonState(isSelectState: CurrentHero.IsAvailable);
    }
    [UsedImplicitly]
    public void SelectHero()
    {
        _onHeroSelected?.Invoke(_currentHeroIndex);
    }
    [UsedImplicitly]
    public void BuyHero()
    {
        if (_wallet.BuyItem(CurrentHero.Price))
        {
            CurrentHero.MarkAsAvailable();
            UpdateButtonState(isSelectState: true);
        }
    }

    public void ShowNextHero()
    {
        Show((_currentHeroIndex+1)%_heroes.Length);
    }

    public void ShowPreviousHero()
    {
        Show((_currentHeroIndex-1+_heroes.Length)%_heroes.Length);
    }
    private void UpdateButtonState(bool isSelectState)
    {
        _selectButton.SetActive(isSelectState);
        _buyButton.SetActive(!isSelectState);
    }
}