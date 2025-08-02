using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private Transform _left;
    [SerializeField] private Transform _right;
    [SerializeField] private float _distance;
    [SerializeField] private float _speed;
    
    private Coroutine _moveRight;
    private Coroutine _moveLeft;
    private void Start()
    {
        
        _moveRight = StartCoroutine(MoveRight());
        _moveLeft = StartCoroutine(MoveLeft());
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    private IEnumerator MoveRight()
    {
        while (Vector3.Distance(transform.position, _right.position) > _distance)
        {
            GetComponent<Rigidbody>().MovePosition(_right.position);
            transform.Translate(Vector3.Lerp(transform.position, _right.position, 1.0f));
            yield return null;
        }
        
    }

    private IEnumerator MoveLeft()
    {
        while (Vector3.Distance(transform.position, _left.position) > _distance)
        {
            GetComponent<Rigidbody>().MovePosition(_left.position);
            transform.Translate(Vector3.Lerp(transform.position, _left.position, 1.0f));
            yield return null;
        }

    }
}
