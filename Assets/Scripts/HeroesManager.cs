using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class HeroesManager : MonoBehaviour
{
    [SerializeField] private List<HeroSettings> _listHeroes;
    private int _currentIndexHero = 3;
    private HeroSettings _currentHero;

    public HeroSettings ShowCurrentHero()
    {
         _currentHero = Instantiate(_listHeroes[_currentIndexHero]);
      return _currentHero ;
    }

    
    public HeroSettings NextHero()
    {   
        Destroy(_currentHero.gameObject);
        _currentIndexHero = (_currentIndexHero + 1) % _listHeroes.Count;
        _currentHero = Instantiate(_listHeroes[_currentIndexHero]);
        return _currentHero;
    }
    
    public HeroSettings PreviousHero()
    {
        Destroy(_currentHero.gameObject);
        _currentIndexHero = (_currentIndexHero - 1 +_listHeroes.Count) % _listHeroes.Count;
        _currentHero = Instantiate(_listHeroes[_currentIndexHero]);
        return _currentHero;
    }
    
        
        
}
