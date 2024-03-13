using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterStats : MonoBehaviour
{
    public UnityEvent<int> IntelligenceChange;
    [SerializeField] private int _intelligence;
    public int Intellegence
    {
        get => _intelligence;
        set
        {
            _intelligence = value;
            IntelligenceChange.Invoke(value);
        }
    }

    public UnityEvent<int> StrengthChange;
    [SerializeField] private int _strength;
    public int Strength
    {
        get => _strength;
        set
        {
            _strength = value;
            StrengthChange.Invoke(value);
        }
    }

    private void Start()
    {
        IntelligenceChange.Invoke(0);
        StrengthChange.Invoke(0);
    }

    public void LevelUp()
    {
        Strength += 5;
        Intellegence += 3;
    }
}
