using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon",menuName ="Shop/Weapon",order =51)]
public class Weapon : Goods
{
    [SerializeField] private float _damage;

    public override void ShowInfo()
    {
        Debug.Log($"Название - {Lable}. Описание - {Description}. Цена - {Price}. Урон - {_damage}");
    }
}
