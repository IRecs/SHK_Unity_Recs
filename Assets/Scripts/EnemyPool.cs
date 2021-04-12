using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyPool : MonoBehaviour
{
    public event UnityAction AllEnemyDie;

    private Enemy[] _enemys;
    private int _defeatedEnemies;

    private void OnEnable()
    {
        _defeatedEnemies = 0;
        _enemys = FindObjectsOfType<Enemy>();

        for (int i = 0; i < _enemys.Length; i++)
        {
            _enemys[i].EnemyDie += OnRecountDefeatedEnemies;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < _enemys.Length; i++)
        {
            _enemys[i].EnemyDie -= OnRecountDefeatedEnemies;
        }
    }

    private void OnRecountDefeatedEnemies()
    {
        ++_defeatedEnemies;
        if (_defeatedEnemies == _enemys.Length)
            AllEnemyDie?.Invoke();
    }
}
