using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : Factory
{
    [SerializeField] private List<ShopUnit> _units;
    public override IProduct GetProduct(string id)
    {
        var unit = _units.Find(unit => unit.ID.Equals(id));
        return Instantiate(unit.Item);
    }

    public List<ShopUnit> Units => _units;
} 