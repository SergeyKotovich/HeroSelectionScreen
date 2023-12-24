using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroStatsView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _heroName;
    [SerializeField] private Slider _health;
    [SerializeField] private Slider _attack;
    [SerializeField] private Slider _defense;
    [SerializeField] private Slider _speed;
    [SerializeField] private TextMeshProUGUI _costHero;
    
    public void Show(HeroSettings currentHero)
    {
        _heroName.text = currentHero.Name;
        _health.value = currentHero.Health;
        _attack.value = currentHero.Attack;
        _defense.value = currentHero.Defense;
        _speed.value = currentHero.Speed;
        _costHero.text = currentHero.Price.ToString();
    }
}