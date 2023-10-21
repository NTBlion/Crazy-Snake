using System.Collections;
using UnityEngine;

namespace Drawing
{
    public class TailDrawer : MonoBehaviour
    {
        [SerializeField] private TailGenerator _tailGenerator;
        [SerializeField] private TailGenerator _scoreTailGenerator;
        [SerializeField] private FollowTarget _followTarget;

        private Coroutine _tailUpdating;
        private Tail _tail;
        private bool _isScoreTail;

        public void StartDrawing()
        {
            SetTail(_tailGenerator);
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
            {
                SetTail(_tailGenerator);
            }
            else
            {
                SetTail(_scoreTailGenerator);
            }
        }

        private void SetTail(TailGenerator generator)
        {
            _tail = generator.Generate(_followTarget.Position);
            _isScoreTail = generator == _scoreTailGenerator;
        }
    }
}