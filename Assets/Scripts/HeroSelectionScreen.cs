using UnityEngine;

public class HeroSelectionScreen : MonoBehaviour
{
    [SerializeField] private HeroStatsView _heroStatsView;
    private HeroesManager _heroesManager;
    private int _currentIndexHero = 3;

    public void Initialize(HeroesManager heroesManager)
    {
        _heroesManager = heroesManager;
    }

    public void ShowScreen()
    {
       var currentHero =  _heroesManager.ShowCurrentHero();
        _heroStatsView.Initialize(currentHero);
    }

    public void ShowNextHero()
    {
       var currentHero =  _heroesManager.NextHero();
       _heroStatsView.Initialize(currentHero);
    }
    public void ShowPreviousHero()
    {
        var currentHero =  _heroesManager.PreviousHero();
        _heroStatsView.Initialize(currentHero);
    }
    
}
