using UnityEngine;

namespace Collision
{
    public class PhysicsZone : MonoBehaviour
    {
        private IDiebale _diebale;
        private IScorable _scorable;
        private int _points;

        public void Init(IDiebale diebale, IScorable scorable, int points)
        {
            _diebale = diebale;
            _scorable = scorable;
            _points = points;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out IDiebale diebaleSnake) == false)
                return;

            if (_diebale != diebaleSnake)
            {
                _scorable.AddScore(_points);
                Debug.Log(_points);
            }

            diebaleSnake.Die();
        }
    }
}