using System;
using UnityEngine;

public class MenuView : MonoBehaviour
{
    [SerializeField] private ShopController _shop;
    [SerializeField] private Cabin _cabin;

    private void Awake()
    {
        _cabin.CabinTouched += OnCabinTouched;
    }

    private void OnCabinTouched()
    {
        Instantiate(_shop, transform);
    }

    private void OnDestroy()
    {
        _cabin.CabinTouched -= OnCabinTouched;
    }
}
