using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _targetScore;
    private int _currentScore;

    public event UnityAction LevelPassed;

    private void Start()
    {
        _targetScore = FindObjectsOfType<Enemy>().Length;
    }

    public void AddScorePoint()
    {
        _currentScore++;

        if (_currentScore >= _targetScore)
            LevelPassed?.Invoke();
    }
}
