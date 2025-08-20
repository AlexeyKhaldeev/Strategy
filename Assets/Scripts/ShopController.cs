 using System;
 using UnityEngine;
 using UnityEngine.Serialization;

 public class ShopController : MonoBehaviour
{
    [SerializeField] private ShopItem _initialItem;
    [SerializeField] private RectTransform _parent;
    [SerializeField] private UnitFactory _factory;
    public void Start()
    {
        foreach (var unit in _factory.Units)
        {
            var item = Instantiate(_initialItem, _parent);
            item.gameObject.SetActive(true);
            item.SetId(unit.ID);
            item.SetPrice(unit.Price.ToString());
            item.SetCallBack(OnItemBought);
        }
        
    }
    private void OnItemBought(string id)
    {
        _factory.GetProduct(id);
    }

    public void OnCloseButtonClick()
    { 
        Destroy(gameObject);
    }

}
 
