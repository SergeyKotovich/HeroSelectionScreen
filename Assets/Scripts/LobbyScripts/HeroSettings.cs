using System;
using UnityEngine;

[Serializable]
public class HeroSettings
{
    [field:SerializeField] public string Name { get; private set; }
    [field:SerializeField] public int Health { get; private set; }
    [field:SerializeField] public int Attack { get; private set; }
    [field:SerializeField] public int Defense { get; private set; }
    [field:SerializeField] public int Speed { get; private set; }
    [field:SerializeField] public float Price { get; private set; }
    [field:SerializeField] public GameObject Prefab { get; private set; }
    public bool IsAvailable;

    public void MarkAsAvailable()
    {
        IsAvailable = true;
    }

}