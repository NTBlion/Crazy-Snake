using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    internal class TailContainer : MonoBehaviour
    {
        [SerializeField] private List<Tail> _tails = new();
        [SerializeField] private int _count;


        internal void AddTail(Tail tail)
        {
            _tails.Add(tail);
            _count++;
        }

        private void Update()
        {
            MakeSpace();
        }

        private void MakeSpace()
        {
            if (_count % 4 == 0)
            {
                _tails[_count-1].DisableMesh();
                _tails[_count - 1].MakeTrigger();
            }
        }
    }
}