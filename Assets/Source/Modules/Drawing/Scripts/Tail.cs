using System;
using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    internal class Tail : MonoBehaviour
    {
        private readonly List<Vector2> _points = new();

        [SerializeField] private LineRenderer _line;
        [SerializeField] private EdgeCollider2D _collider;

        [SerializeField] [Min(1)] private int _lenght;
        [SerializeField] [Min(0.1f)] private float _distanceBetweenPoints = 0.1f;

        public bool IsDrawn => _lenght <= _line.positionCount;

        internal void Init()
        {
            _collider.transform.position -= transform.position;
        }

        internal void DrawLine(Vector2 position)
        {
            if (IsDrawn)
            {
                throw new AggregateException("Tail is already drawn");
            }
            
            _points.Add(position);

            _line.positionCount++;
            _line.SetPosition(_line.positionCount - 1, position);
            _collider.points = _points.ToArray();
        }

        internal bool CanAppend(Vector2 position)
        {
            if (_line.positionCount == 0)
            {
                return true;
            }

            return HasEnoughDistanceBetweenPoints(position);
        }

        private bool HasEnoughDistanceBetweenPoints(Vector2 position)
        {
            return Vector2.Distance(_line.GetPosition(_line.positionCount - 1), position) > _distanceBetweenPoints;
        }
    }
}