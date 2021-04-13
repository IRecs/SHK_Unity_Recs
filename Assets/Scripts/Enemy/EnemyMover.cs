using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : Mover
{
    public override void Move(Vector2 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, CurrentSpeed * Time.fixedDeltaTime);
    }
}
