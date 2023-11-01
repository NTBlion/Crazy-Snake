using UnityEngine;

namespace Drawing
{
    public interface ITailGenerator
    {
        public Tail Generate(Vector3 position);
    }
}