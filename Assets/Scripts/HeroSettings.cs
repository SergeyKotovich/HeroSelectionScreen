using System;
using UnityEngine;
using UnityEngine.UI;



public class HeroSettings : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _attack;
    [SerializeField] private float _defense;
    [SerializeField] private float _speed;
    [field:SerializeField] public string Name { get; private set; }
    [field:SerializeField] public string Description { get; private set; }
    [field:SerializeField] public float Experience { get; private set; }
    [field:SerializeField] public Sprite Icon { get; private set; }
    public float HEALTH => _health;
    public float ATTACK => _attack;
    public float DEFENSE => _defense;
    public float SPEED => _speed;
}
