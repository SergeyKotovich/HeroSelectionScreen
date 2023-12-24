using UnityEngine;

public class HeroLoader : MonoBehaviour
{
    [SerializeField] private Transform _heroRoot;
    private GameObject _hero;

    public void Show(HeroSettings heroSettings)
    {
        //  foreach (Transform childObject in _heroRoot)
      //  {
      //      Destroy(childObject.gameObject);
      //  }
      if (_hero!=null)
      {
          Destroy(_hero.gameObject);
      }
      _hero = Instantiate(heroSettings.Prefab);
    }
}