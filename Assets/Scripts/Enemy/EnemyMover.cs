using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : BeingMover
{
    public override void Move(Vector2 targetPosition)
    {
        Transform.position = Vector3.MoveTowards(Transform.position, targetPosition, CurrentSpeed * Time.fixedDeltaTime);
    }

}
