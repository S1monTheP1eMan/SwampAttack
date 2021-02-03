using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private bool _isBought;
    [SerializeField] private Sprite _icon;

    [SerializeField] protected Bullet Bullet;

    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsBought => _isBought;

    public abstract void Shoot(Transform shootPoint, Transform shootPoint1, Transform shootPoint2);

    public void Buy()
    {
        _isBought = true;
    }
}
