using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private static readonly int Speed = Animator.StringToHash("Speed");
    
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Animator _animator;

    private Ground[] _grounds;
    private readonly CancellationTokenSource _tokenSource = new();
    
    private void Awake()
    {
        _grounds = FindObjectsOfType<Ground>();
    }

    private void OnEnable()
    {
        foreach (var ground  in _grounds)
        {
            ground.GroundTouched += MoveTo;
        }
    }

    private void OnDisable()
    {
        foreach (var ground  in _grounds)
        {
            ground.GroundTouched -= MoveTo;
        }
    }

    private void Update()
    {
      
        _animator.SetFloat(Speed, _agent.velocity.magnitude);
    }

    public void MoveTo(Vector3 targetPos)
    {
        _agent.SetDestination(targetPos);
    }
} 
