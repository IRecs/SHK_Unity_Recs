using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public GameObject BonusContainer => _bonusContainer;

    [SerializeField] private GameObject _bonusContainer;
}
