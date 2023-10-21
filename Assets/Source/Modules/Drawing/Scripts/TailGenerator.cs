using UnityEngine;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;

        internal Tail Generate(Vector3 position)
        {
            Tail tail = Instantiate(_tail, position, Quaternion.identity);
            tail.Init();

            return tail;
        }
    }
}