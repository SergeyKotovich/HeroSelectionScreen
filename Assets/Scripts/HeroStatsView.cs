using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroStatsView : MonoBehaviour
{
    [SerializeField] private Slider _health;
    [SerializeField] private Slider _attack;
    [SerializeField] private Slider _defense;
    [SerializeField] private Slider _speed;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private Slider _experience;
    [SerializeField] private Image _icon;
    

    public void Initialize(HeroSettings currentHero)
    {
        _health.value = currentHero.HEALTH;
        _attack.value = currentHero.ATTACK;
        _defense.value = currentHero.DEFENSE;
        _speed.value = currentHero.SPEED;
        _name.text = currentHero.Name;
        _description.text = currentHero.Description;
        _experience.value = currentHero.Experience;
        _icon.sprite = currentHero.Icon;
    }
    
}
