using System.Collections;
using UnityEngine;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private FollowTarget _followTarget;
        [SerializeField] private float _tailDrawDelay;

        private Tail _currentTail;

        private void Awake()
        {
            Generate();
        }

        private void Update()
        {
            _currentTail.DrawLine(_followTarget.transform.position);
        }

        internal void Generate()
        {
            _currentTail = Instantiate(_tail, _followTarget.transform.position, Quaternion.identity);
        }
    }
}