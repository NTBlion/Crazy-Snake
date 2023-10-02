using System;
using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    internal class Tail : MonoBehaviour
    {
        private float _time;
        
        private void Update()
        {
            _time += Time.deltaTime;
            Scale();
            if (_time > 5)
            {
                StopScale();
            }
        }

        private void Scale()
        {
            transform.localPosition += Vector3.left * Time.deltaTime / 2f;
            transform.localScale += Vector3.right * Time.deltaTime;
        }

        private void StopScale()
        {
            transform.localPosition = transform.localPosition;
            transform.localScale = transform.localScale;
        }
    }
}