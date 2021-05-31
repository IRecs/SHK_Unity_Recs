using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _gameOverPanel;

    private void OnEnable()
    {
        _player.LevelPassed += OnLevelPassed;
    }

    private void OnDisable()
    {
        _player.LevelPassed -= OnLevelPassed;
    }

    private void OnLevelPassed()
    {
        _gameOverPanel.SetActive(true);
    }
}
