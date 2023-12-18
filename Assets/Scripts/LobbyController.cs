using JetBrains.Annotations;
using UnityEngine;

public class LobbyController : MonoBehaviour
{
    [SerializeField] private HeroSelectionScreen _heroSelectionScreen;
    [SerializeField] private LobbyScreen _lobbyScreen;
    [SerializeField] private HeroesManager _heroesManager;
    [SerializeField] private HeroStatsView _heroStatsView;

    private void Awake()
    {
        _heroSelectionScreen.Initialize(_heroesManager);
    }
    [UsedImplicitly]
    public void ShowHeroSelectionScreen()
    {
        _heroSelectionScreen.ShowScreen();
    }

    private void ShowLobbyScreen()
    {
        _lobbyScreen.ShowScreen();
    }
}
