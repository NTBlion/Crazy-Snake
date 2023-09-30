using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    internal class Tail : MonoBehaviour
    {
        [SerializeField] private LineRenderer _line;
        [SerializeField] private EdgeCollider2D _collider;
        [SerializeField] private float _distanceBetweenPoints = 0.1f;

        private readonly List<Vector2> _points = new List<Vector2>();
        private void OnValidate()
        {
            if (_distanceBetweenPoints < 0.1f)
                _distanceBetweenPoints = 0.1f;
        }

        private void Start()
        {
            _collider.transform.position -= transform.position;
        }

        internal void SetPosition(Vector2 position)
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
                return true;

            return Vector2.Distance(_line.GetPosition(_line.positionCount - 1), position) > _distanceBetweenPoints;
        }
    }
}