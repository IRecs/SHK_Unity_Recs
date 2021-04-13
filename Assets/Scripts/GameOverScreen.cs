using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private EnemyPool _enemyPool;
    [SerializeField] private GameObject _gameOverPanel;

    private void OnEnable()
    {
        _enemyPool.AllEnemyDie += OnAllEnemyDie;
    }

    private void OnDisable()
    {
        _enemyPool.AllEnemyDie -= OnAllEnemyDie;
    }

    private void OnAllEnemyDie()
    {
        _gameOverPanel.SetActive(true);
    }
}
