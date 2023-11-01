using UnityEngine;

namespace Collision
{
    public class ScoreZone : MonoBehaviour
    {
        private IScorable _scorable;
        private int _points;

        public void Init(IScorable scorable, int points)
        {
            _scorable = scorable;
            _points = points;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out IScorable scoreSnake) == false)
                return;

            if (scoreSnake == _scorable)
                return;

            scoreSnake.AddScore(_points);
            Debug.Log(_points);
        }
    }
}