using System;
using UnityEngine;

public class LobbyController : MonoBehaviour
{
    [SerializeField] private HeroesSettings heroesSettings;
    [SerializeField] private Wallet _wallet;
    [SerializeField] private HeroSelectScreen _heroSelectScreen;
    [SerializeField] private LobbyScreen _lobbyScreen;
    private int _currentHeroIndex = 3;

    private void Awake()
    {
        ShowLobbyScreen();
    }

    public void ShowSelectScreen()
    {
        _heroSelectScreen.Initialize(_currentHeroIndex,heroesSettings.Heroes,_wallet, OnHeroSelected );
    }

    public void ShowLobbyScreen()
    {
        _lobbyScreen.Show(_currentHeroIndex,heroesSettings);
    }

    private void OnHeroSelected(int heroIndex)
    {
        _currentHeroIndex = heroIndex;
    }
    
}
