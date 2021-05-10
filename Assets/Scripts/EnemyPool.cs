using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyPool : MonoBehaviour
{
    public event UnityAction AllEnemyDie;

    private Enemy[] _enemies;
    private int _defeatedEnemies;

    private void OnEnable()
    {
        _defeatedEnemies = 0;
        _enemies = FindObjectsOfType<Enemy>();

        for (int i = 0; i < _enemies.Length; i++)
        {
            _enemies[i].EnemyDie += OnRecountDefeatedEnemies;
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < _enemies.Length; i++)
        {
            _enemies[i].EnemyDie -= OnRecountDefeatedEnemies;
        }
    }

    private void OnRecountDefeatedEnemies()
    {
        _defeatedEnemies++;
        if (_defeatedEnemies == _enemies.Length)
            AllEnemyDie?.Invoke();
    }
}
