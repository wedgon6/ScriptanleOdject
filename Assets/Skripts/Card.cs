using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName ="Card/Create New Card", order = 51)]
public class Card : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private Sprite _icon;

    public string Name => _name;
    public int Health => _health;
    public int Damege => _damage;
    public Sprite Icon => _icon;
}
