using System;
using UnityEngine;

namespace Score
{
    internal class ScoreZone : MonoBehaviour
    {
        private Score _score;

        internal void Init(Score score)
        {
            _score = score;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out Score score) == false)
                return;
            
            if (_score == score)
                return;
            
            _score.AddPoints();
        }
    }
}
