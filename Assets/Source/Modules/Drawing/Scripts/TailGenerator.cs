using System;
using System.Collections;
using UnityEngine;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private FollowTarget _followTarget;
        [SerializeField] private TailContainer _tailContainer;

        private Tail _currentTail;

        private void OnDisable()
        {
            _currentTail.ReachedMaxLength -= OnReachedMaxLength;
        }

        private void Start()
        {
            Generate();
        }

        private void Update()
        {
            _currentTail.DrawLine(_followTarget.transform.position);
        }

        internal void Generate()
        {
            _currentTail = Instantiate(_tail, _followTarget.transform.position, Quaternion.identity,_tailContainer.transform);
            _tailContainer.AddTail(_currentTail);
            _currentTail.ReachedMaxLength += OnReachedMaxLength;
        }

        private void OnReachedMaxLength()
        {
            Generate();
        }
    }
}