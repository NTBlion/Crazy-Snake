using System.Collections;
using UnityEngine;

namespace Drawing
{
    public class TailDrawer : MonoBehaviour
    {
        [SerializeField] private FollowTarget _followTarget;

        private ITailGenerator _physicsTailGenerator;
        private ITailGenerator _scoreZoneGenerator;

        private Coroutine _tailUpdating;
        private Tail _tail;

        private bool _isScoreTail;

        public void Init(ITailGenerator physicsTailGenerator, ITailGenerator scoreTailGenerator)
        {
            _physicsTailGenerator = physicsTailGenerator;
            _scoreZoneGenerator = scoreTailGenerator;
        }

        public void StartDrawing()
        {
            SetTail(_physicsTailGenerator);
            _tailUpdating = StartCoroutine(TailUpdating());
        }

        private IEnumerator TailUpdating()
        {
            while (_tail.IsDrawn == false)
            {
                yield return new WaitUntil(() => _tail.CanAppend(_followTarget.Position));
                _tail.DrawLine(_followTarget.Position);
            }

            SwitchTail();
            _tailUpdating = StartCoroutine(TailUpdating());
        }

        private void SwitchTail()
        {
            if (_isScoreTail)
                SetTail(_physicsTailGenerator);
            else
                SetTail(_scoreZoneGenerator);
        }

        private void SetTail(ITailGenerator generator)
        {
            _tail = generator.Generate(_followTarget.Position);
            _isScoreTail = generator == _scoreZoneGenerator;
        }
    }
}