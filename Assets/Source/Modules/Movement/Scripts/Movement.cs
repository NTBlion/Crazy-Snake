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
            _direction =transform.right * _speed * Time.deltaTime;
        }

        private void FixedUpdate()
        {
            Move(_direction);
        }

        internal void Move(Vector2 direction)
        {
            _rigidbody.velocity = transform.right * _speed * Time.deltaTime;
        }
    }
}
