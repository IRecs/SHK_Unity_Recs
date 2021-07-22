using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private const float _maximumSpeed = 25f;

    [SerializeField] private float _speed;

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public bool TryChangeSpeedBy(float value)
    {
        if (_speed + value < 0 || _speed + value > _maximumSpeed)
            return false;

        _speed += value;
        return true;
    }
}
