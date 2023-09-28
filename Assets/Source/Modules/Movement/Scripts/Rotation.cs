using System;
using System.Timers;
using UnityEngine;

namespace Movement
{
    internal class Rotation : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _rotationSpeed;

        internal void Rotate(float direction)
        {
            _rigidbody.MoveRotation(_rigidbody.rotation + (direction * _rotationSpeed) * Time.fixedDeltaTime);
        }
    }
}