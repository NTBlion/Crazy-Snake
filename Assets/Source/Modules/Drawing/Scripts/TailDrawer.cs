using System.Collections;
using UnityEngine;

namespace Drawing
{
    public class TailDrawer : MonoBehaviour
    {
        [SerializeField] private TailGenerator _tailGenerator;
        [SerializeField] private FollowTarget _followTarget;
        [SerializeField] [Min(1)] private int _tailLenght;
        [SerializeField] [Min(1)] private int _scoreZoneLenght;

        private Coroutine _tailUpdating;
        private Tail _tail;

        public void EnableDrawing()
        {
            _tail = _tailGenerator.Generate(_followTarget.Position);
            _tailUpdating = StartCoroutine(TailUpdating());
        }
        
        private IEnumerator TailUpdating()
        {
            for (int i = 0; i < _tailLenght; i++)
            {
                yield return new WaitUntil(() => _tail.CanAppend(_followTarget.Position));
                _tail.DrawLine(_followTarget.Position);
            }
        }
    }
}