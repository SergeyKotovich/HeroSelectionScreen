using UnityEngine;

public class HeroesSettings : MonoBehaviour
{
    [field: SerializeField] public HeroSettings[] Heroes { get; private set; }
}
