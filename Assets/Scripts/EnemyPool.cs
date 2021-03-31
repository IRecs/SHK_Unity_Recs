using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyPool : MonoBehaviour
{
    public event UnityAction AllEnemyDie;

    [SerializeField] private Enemy[] _enemys;

    private int _defeatedEnemies;

    private void OnEnable()
    {
        for (int i = 0; i < _enemys.Length; i++)
        {
            _enemys[i].EnemyDie += RecountDefeatedEnemies;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < _enemys.Length; i++)
        {
            _enemys[i].EnemyDie -= RecountDefeatedEnemies;
        }
    }

    private void RecountDefeatedEnemies()
    {
        ++_defeatedEnemies;
        if (_defeatedEnemies == _enemys.Length)
            AllEnemyDie?.Invoke();
    }
}
