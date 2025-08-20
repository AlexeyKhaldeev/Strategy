using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] private int _iterationsCount;

    private Stack _stack; 
    private Queue _queue;
    void Update()
    {
        for (int i = 0; i < _iterationsCount; i++)
        {
            Instantiate(_prefab, transform);
        }
        
    }
}
