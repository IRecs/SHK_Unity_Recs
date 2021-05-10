using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _radiusMovement = 4;
    private Vector3 _targetPosition;

    public event UnityAction EnemyDie;

    private void FixedUpdate()
    {
        if (transform.position != _targetPosition)
            Move();            
        else
            SearchTargetPosition();
    }

    private void SearchTargetPosition()
    {
        _targetPosition = Random.insideUnitCircle * _radiusMovement;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.fixedDeltaTime);
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
