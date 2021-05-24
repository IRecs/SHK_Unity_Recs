using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _bonusContainer;
    private int _targetScore;
    private int _currentScore;

    public GameObject BonusContainer => _bonusContainer;
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
