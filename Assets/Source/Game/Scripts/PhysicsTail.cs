using Collision;
using Drawing;
using UnityEngine;

namespace CrazySnake
{
    public class PhysicsTail : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private PhysicsZone _zone;

        public Tail Tail => _tail;
        public PhysicsZone Zone => _zone;
    }
}