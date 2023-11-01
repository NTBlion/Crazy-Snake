using UnityEngine;
using Collision;
using Drawing;

namespace CrazySnake
{
    public class PhysicsZoneGenerator : MonoBehaviour, ITailGenerator
    {
        [SerializeField] private PhysicsTail _physicsTail;
        [SerializeField] private int _points;

        private IDiebale _diebale;
        private IScorable _scorable;

        public void Init(IDiebale diebale, IScorable scorable)
        {
            _diebale = diebale;
            _scorable = scorable;
        }

        public Tail Generate(Vector3 position)
        {
            var physicsTail = Instantiate(_physicsTail, position, Quaternion.identity);
            physicsTail.Zone.Init(_diebale, _scorable, _points);

            return physicsTail.Tail;
        }
    }
}