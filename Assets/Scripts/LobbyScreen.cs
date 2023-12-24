using UnityEngine;

public class LobbyScreen : MonoBehaviour
{
    [SerializeField] private HeroLoader _heroLoader;

    public void Show(int currentHeroIndex , HeroesSettings  heroesSettings)
    {
        _heroLoader.Show(heroesSettings.Heroes[currentHeroIndex]);
    }
    
}
