using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    private float _time;
    private Coroutine _coroutine;

    private void Start()
    {
        //Invoke(nameof(StopPrinting), 2.0f);
    }
    
    public IEnumerator Print()
    {
            PrintFrame();
            yield return new WaitForKey(KeyCode.Space);
            PrintFrame();
    }

    
    private void OnDestroy()
    {
        StopCoroutine(Print());
    }

    private void PrintFrame()
    {
       // Debug.Log(Time.frameCount);
    }

    
    
}
