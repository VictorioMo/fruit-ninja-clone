using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Fruit Slicing Sounds")]
    [SerializeField] AudioSource _fruitSlice1;
    [SerializeField] AudioSource _fruitSlice2;
    [SerializeField] AudioSource _fruitSlice3;

    [Header("Bomb explosion sound")]
    [SerializeField] AudioSource _bombExplosion;

    public void PlaySound_BombExplosion()
    {
        _bombExplosion.Play();
    }

    public void PlaySound_FruitSlice()
    {
        switch(Random.Range(1,4))
        {
            case 1: _fruitSlice1.Play(); break;
            case 2: _fruitSlice2.Play(); break;
            case 3: _fruitSlice3.Play(); break;

            default:
                _fruitSlice1.Play(); break;
        }
    }
}
