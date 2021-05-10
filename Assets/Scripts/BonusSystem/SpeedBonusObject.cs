using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonusObject : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _duration;

    private void ArrangeBonus(Player player)
    {
        if (player.TryGetComponent(out PlayerMover mover))
        {
            GameObject container = player.BonusContainer;

            if (!container.TryGetComponent(out SpeedBonus speedBonus))
            {
                speedBonus = container.gameObject.AddComponent<SpeedBonus>();
            }
            else if (speedBonus.enabled == false)
            {
                speedBonus.enabled = true;
            }

            speedBonus.SetDuration(_duration);

            if (speedBonus.TrySetForce(_force))
            {
                speedBonus.EnableBonusEffect();
            }
        }
    }
       
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            ArrangeBonus(player);
            gameObject.SetActive(false);
        }
    }
}
