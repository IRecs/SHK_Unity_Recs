using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemyMover))]

public class Enemy : Being
{
    public event UnityAction EnemyDie;

    private EnemyMover _mover;
    private Vector3 _targetPosition;
    private Transform _transform;

    private void Start()
    {
        _mover = GetComponent<EnemyMover>();
        _transform = GetComponent<Transform>();        
    }

    private void FixedUpdate()
    {
        if (_transform.position != _targetPosition)
            _mover.Move(_targetPosition);            
        else
            SearchTargetPosition();
    }

    private Vector2 SearchTargetPosition()
    {
        _targetPosition = Random.insideUnitCircle * 4;
        return _targetPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            EnemyDie?.Invoke();
        }
        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }

}
