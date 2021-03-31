using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSystem : MonoBehaviour
{
    [SerializeField] private Being _being;
    [SerializeField] private BeingMover _mover;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out BonusObject bonusObject))
        {
            Bonus bonus = null;
            float durationBonus, forceBonus;

            bonusObject.GetBonusMetrics(out durationBonus, out forceBonus);
            bonusObject.gameObject.SetActive(false);

            if (collision.TryGetComponent(out SpeedBonusObject speedBonusObject))
                bonus = new SpeedBonus(_mover, forceBonus);
            
            StartCoroutine(BonesActive(bonus, durationBonus));
        }
    }

    private IEnumerator BonesActive(Bonus bonus ,float duration)
    {
        if (bonus != null)
        {
            bonus.EnableBonus();
            yield return new WaitForSeconds(duration);
            bonus.DisableBonus();
        }
    }
}
