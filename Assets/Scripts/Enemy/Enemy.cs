using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _radiusMovement = 4;
    private Vector3 _targetPosition;

    public event UnityAction<Enemy> Die;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if (transform.position == _targetPosition)
            _targetPosition = Random.insideUnitCircle * _radiusMovement;

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            Die?.Invoke(this);
            gameObject.SetActive(false);
        }
    }
}
