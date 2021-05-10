using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public GameObject BonusContainer => _bonusContainer;

    [SerializeField] private GameObject _bonusContainer;
}
