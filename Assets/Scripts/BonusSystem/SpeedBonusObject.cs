using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
public class SpeedBonusObject : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private float _force = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover mover))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            StartCoroutine(WaiteSpeedBoost(mover));
        }
    }

    private IEnumerator WaiteSpeedBoost(PlayerMover mover)
    {
        if (mover.TryChangeSpeedBy(_force))
        {
            yield return new WaitForSeconds(_duration);
            mover.TryChangeSpeedBy(-_force);
        }
        gameObject.SetActive(false);
    }
}
