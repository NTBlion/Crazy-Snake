using System;
using UnityEngine;

namespace Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    internal class ForwardMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody2D _rigidbody;

        private Vector2 _direction;

        private void Awake()
        {
            _direction =transform.right * (_speed * Time.deltaTime);
        }
        
        internal void MoveForward()
        {
            _rigidbody.MovePosition(_rigidbody.position + _direction);
        }
    }
}
