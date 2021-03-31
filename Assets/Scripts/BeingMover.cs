using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BeingMover : MonoBehaviour
{
    [SerializeField] protected float StandartSpeed;
    protected float CurrentSpeed;
    protected Transform Transform;

    private void Start()
    {
        Transform = GetComponent<Transform>();
        CurrentSpeed = StandartSpeed;
    }

    public void SpeedUp(float accelerationFactor)
    {
        CurrentSpeed =  StandartSpeed * accelerationFactor;
    }

    public void ReturnStandardSpeed()
    {
        CurrentSpeed = StandartSpeed;
    }

    public abstract void Move(Vector2 direction);

}
