using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

public abstract class Factory : MonoBehaviour
{
     public abstract IProduct GetProduct();
}
