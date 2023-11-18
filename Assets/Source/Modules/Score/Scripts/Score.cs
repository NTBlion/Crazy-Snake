using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int _winConditionPoints;
    private int _points;

    public event Action GotWinCondition;

    public void AddPoints(int points)
    {
        _points += points;

        if (_points != _winConditionPoints)
            return;

        GotWinCondition?.Invoke();
    }
}