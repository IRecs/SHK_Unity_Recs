using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _radiusMovement = 4;
    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = Random.insideUnitCircle * _radiusMovement;
    }

    private void FixedUpdate()
    {
        MoveLogic();
    }

    private void MoveLogic()
    {
        if (transform.position == _targetPosition)
        {
            _targetPosition = Random.insideUnitCircle * _radiusMovement;
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.AddScorePoint();
            gameObject.SetActive(false);
        }
    }
}
