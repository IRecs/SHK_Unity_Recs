using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : Mover
{
    public override void Move(Vector2 direction)
    {
        transform.Translate(direction * CurrentSpeed * Time.deltaTime);
    }
}
