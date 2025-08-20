
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _price;

    private string _id;

    private Action<string> _buyClicked;


    public void SetId(string id)
    {
        _id = id;
    }

public void SetCallBack(Action<string> value)
    {
        _buyClicked = value;
    }
    public void SetPrice(string value)
    {
        _price.text = value;
    }

    public void OnBuyButtonClick()
    {
        _buyClicked?.Invoke(_id);
    }
}
