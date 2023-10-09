using System;
using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    internal class Tail : MonoBehaviour
    {
        [SerializeField] private LineRenderer _line;
        [SerializeField] private EdgeCollider2D _collider;
        [SerializeField] private float _distanceBetweenPoints = 0.1f;
        [SerializeField] private int _maxLength = 10;

        private readonly List<Vector2> _points = new();

        internal event Action ReachedMaxLength;

        private void OnValidate()
        {
            if (_distanceBetweenPoints < 0.1f)
                _distanceBetweenPoints = 0.1f;
        }

        private void Start()
        {
            _collider.transform.position -= transform.position;
        }

        internal void DrawLine(Vector2 position)
        {
            if (CanAppend(position) == false)
                return;

            _points.Add(position);

            _line.positionCount++;
            _line.SetPosition(_line.positionCount - 1, position);
            _collider.points = _points.ToArray();
        }

        private bool CanAppend(Vector2 position)
        {
            if (_line.positionCount == 0)
            {
                return true;
            }

            if (_line.positionCount > _maxLength)
            {
                ReachedMaxLength?.Invoke();
                return false;
            }

            return CheckDistance(position);
        }
        
        internal void MakeTrigger()
        {
            _line.enabled = false;
            _collider.enabled = false;
        }
        
        private bool CheckDistance(Vector2 position)
        {
            return Vector2.Distance(_line.GetPosition(_line.positionCount - 1), position) > _distanceBetweenPoints;
        }
    }
}