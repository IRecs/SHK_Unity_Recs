using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : BeingMover
{
    public override void Move(Vector2 direction)
    {
        Transform.Translate(direction * CurrentSpeed * Time.deltaTime);
    }
}
