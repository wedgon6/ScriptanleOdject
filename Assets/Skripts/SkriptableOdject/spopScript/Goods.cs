using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Goods : ScriptableObject
{
    [SerializeField] protected string Lable;
    [SerializeField] protected string Description;
    [SerializeField] protected int Price;

    public abstract void ShowInfo();
}
