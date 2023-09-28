using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movement
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private Movement _movement;
        [SerializeField] private Rotation _rotation;

        [SerializeField] private bool _isMoving;
        [SerializeField] private bool _isRotating;

        private float _axis;

        private void Update()
        {
            _axis = Input.GetAxisRaw("Horizontal");
            
            if (_isRotating)
                _rotation.Rotate(-_axis);
        }

        private void FixedUpdate()
        {
            if (_isMoving)
                _movement.Activate();
            else
                _movement.Deactivate();

            
        }
    }
}