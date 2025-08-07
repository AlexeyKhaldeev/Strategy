using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using System.Threading.Tasks;

public class Player : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private float _speed;

    private CancellationTokenSource _tokenSource;


    private void Start()
    {
        _tokenSource = new CancellationTokenSource();
    }

    private void OnDestroy()
    {
        //StopAllCoroutines();
    }

    public async void MoveTo(Vector3 targetPos)
    {
        // StopAllCoroutines();
        // StartCoroutine(Move(targetPos));
        await MoveAsync(targetPos);
    }
    private IEnumerator Move(Vector3 targetPos)
    {
        while (Vector3.Distance(transform.position, targetPos) > _distance)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, _speed * Time.deltaTime);
            yield return null;
        }

    }
    
    private async Task MoveAsync(Vector3 targetPos)
    {
        await new Task(() =>
        {
            while (Vector3.Distance(transform.position, targetPos) > _distance)
            {
                transform.position = Vector3.Lerp(transform.position, targetPos, _speed * Time.deltaTime);
            }
        }, _tokenSource.Token);
    }
}
