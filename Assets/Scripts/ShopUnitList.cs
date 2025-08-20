using UnityEngine;

[CreateAssetMenu(menuName = "Strategy/ShopUnitList", fileName = "ShopUnitList")]
public class ShopUnitList : ScriptableObject
{
    [SerializeField] private ShopUnit[] _units;
    
    public ShopUnit[] Units => _units;
}
