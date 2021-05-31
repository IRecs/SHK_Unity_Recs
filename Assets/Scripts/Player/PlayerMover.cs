using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private const float _maximumSpeed = 25f;

    private const float _forceSpeedBoost = 2f;
    private float _currentDurationSpeedBoost = 0;
    private bool _isSpeedBoost = false;

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    public void EnableSpeedBoost(float _duration)
    {
        _currentDurationSpeedBoost += _duration;

        if (!_isSpeedBoost)
        {
            _isSpeedBoost = true;
            float speedBonus = Mathf.Abs(_speed - (_speed * _forceSpeedBoost));
            speedBonus = Mathf.Clamp(speedBonus, 0, _maximumSpeed - _speed);

            ChangeSpeed(speedBonus);
            StartCoroutine(WaiteSpeedBoost(speedBonus));
        }
    }   

    private IEnumerator WaiteSpeedBoost(float speedBonus)
    {
        float timeWait = _currentDurationSpeedBoost;
        yield return new WaitForSeconds(timeWait);
        _currentDurationSpeedBoost -= timeWait;

        if(_currentDurationSpeedBoost > 0)
            StartCoroutine(WaiteSpeedBoost(speedBonus));
        else
            DisableSpeedBoost(speedBonus);
    }

    private void DisableSpeedBoost(float speedBonus)
    {
        ChangeSpeed(-speedBonus);
        _isSpeedBoost = false;
    }

    private void ChangeSpeed(float magnitudeChange)
    {
        _speed = Mathf.Clamp(_speed + magnitudeChange, 0, _maximumSpeed);
    }    
}
