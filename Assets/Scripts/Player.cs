using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using System.Threading.Tasks;

public class Player : MonoBehaviour
{
    [SerializeField] private float _distance; 
    [SerializeField] private float _speed;

    private readonly CancellationTokenSource _tokenSource = new();

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    public void MoveTo(Vector3 targetPos)
    {
        StopAllCoroutines();
        StartCoroutine(Move(targetPos));
    }
    private IEnumerator Move(Vector3 targetPos)
    {
        while (Vector3.Distance(transform.position, targetPos) > _distance)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, _speed * Time.deltaTime);
            yield return null;
        }

    }
}
