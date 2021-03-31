using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverSprite;
    [SerializeField] private EnemyPool _enemyPool;

    private void OnEnable()
    {
        _enemyPool.AllEnemyDie += OpenGameOverSprite;
    }

    private void OnDisable()
    {
        _enemyPool.AllEnemyDie -= OpenGameOverSprite;
    }

    private void OpenGameOverSprite()
    {
        _gameOverSprite.SetActive(true);
    }
}
