using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    [SerializeField] private EnemyGroup _enemyGroup;
    [SerializeField] private GameObject _gameOverPanel;

    private void OnEnable()
    {
        _enemyGroup.LevelPassed += OnLevelPassed;
    }

    private void OnDisable()
    {
        _enemyGroup.LevelPassed -= OnLevelPassed;
    }

    private void OnLevelPassed()
    {
        _gameOverPanel.SetActive(true);
    }
}
