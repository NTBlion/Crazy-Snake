using System;
using UnityEngine;

namespace Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    internal class Movement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody2D _rigidbody;

        private Vector2 _direction;

        private void Update()
        {
            _direction =transform.right * (_speed * Time.fixedDeltaTime);
        }

        internal void Activate()
        {
            Move();
        }

        internal void Deactivate()
        {
            _rigidbody.Sleep();
        }
        
        private void Move()
        {
            _rigidbody.MovePosition(_rigidbody.position + _direction);
        }
    }
}
