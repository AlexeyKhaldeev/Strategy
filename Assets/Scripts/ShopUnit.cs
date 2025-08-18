using System;
using UnityEngine;


[CreateAssetMenu(menuName = "Strategy/ShopUnitList", fileName = "ShopUnitList")]
public class ShopUnitList : ScriptableObject
{
    public ShopUnit[] Units => _units;

    [SerializeField] private ShopUnit[] _units;
}

[Serializable]
public struct ShopUnit
{
    public int Price;
}