using UnityEngine;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        
        internal Tail Generate(Vector3 position)
        {
           return Instantiate(_tail, position, Quaternion.identity);
        }
    }
}