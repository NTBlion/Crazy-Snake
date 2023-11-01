using UnityEngine;
using Collision;
using Drawing;

namespace CrazySnake
{
    public class ScoreZoneTail : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private ScoreZone _zone;

        public Tail Tail => _tail;
        public ScoreZone Zone => _zone;
    }
}