using UnityEngine;
using Drawing;

namespace CrazySnake
{
    public class ScoreZoneGenerate : MonoBehaviour
    {
         [SerializeField] private ScoreZoneTail _scoreZoneTail;
         [SerializeField] private int _points;
        
        public void Init(IScorable scorable)
         {
             _scorable = scorable;
         }
        
         public Tail Generate(Vector3 position)
         {
             var scoreZoneTail = Instantiate(_scoreZoneTail, position, Quaternion.identity);
             scoreZoneTail.Zone.Init(_scorable, _points);
        
             return scoreZoneTail.Tail;
         }
    }
}