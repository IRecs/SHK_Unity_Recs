using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    protected float CurrentSpeed { get; private set; }

    [SerializeField] private float _standartSpeed;

    private void Start()
    {
        CurrentSpeed = _standartSpeed;
    }

    public void ChangeSpeed(float accelerationFactor)
    {
        CurrentSpeed = CurrentSpeed * accelerationFactor;
    }

    public void ReturnStandardSpeed()
    {
        CurrentSpeed = _standartSpeed;
    }

    public abstract void Move(Vector2 direction);

}
