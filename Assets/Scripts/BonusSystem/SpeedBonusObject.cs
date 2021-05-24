using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonusObject : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover mover))
        {
            GameObject container = mover.GetComponent<Player>().BonusContainer;

            if (!container.TryGetComponent(out SpeedBonus speedBonus))
            {
                speedBonus = container.gameObject.AddComponent<SpeedBonus>();
            }
            else if (speedBonus.enabled == false)
            {
                speedBonus.enabled = true;
            }

            speedBonus.Enable(_force, _duration);
            gameObject.SetActive(false);
        }
    }
}
