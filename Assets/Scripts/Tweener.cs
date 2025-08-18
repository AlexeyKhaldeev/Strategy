using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;


public class Tweener : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForKey(KeyCode.Space);
        transform.DOMove(transform.position + Vector3.left * 5.0f, 2.0f);
    }
}
