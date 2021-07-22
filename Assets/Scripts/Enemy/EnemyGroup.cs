using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyGroup : MonoBehaviour
{
    [SerializeField] private List<Enemy> _enemies = new List<Enemy>();

    public int CountEnemies => _enemies.Count;

    public event UnityAction LevelPassed;

    private void Awake()
    {
        foreach (var enemy in _enemies)
        {
            enemy.Die += OnDie;
        }
    }

    public void OnDie(Enemy enemy)
    {
        enemy.Die -= OnDie;
        _enemies.Remove(enemy);

        if (_enemies.Count == 0)
            LevelPassed?.Invoke();
    }
}
