using System;
using UnityEngine;

namespace Score
{
    public class Score : MonoBehaviour
    {
        [SerializeField] [Range(1,10)] private int _pointsToAdd;
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

        public void ClearPoints() => _points = 0;
    }
}