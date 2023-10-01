using UnityEngine;
using UnityEngine.Serialization;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private SpawnPoint _followTarget;

        private Tail _currentTail;

        private void Awake()
        {
            Generate();
        }

        private void Update()
        {
            if (_currentTail != null)
                _currentTail.SetPosition(_followTarget.transform.position);
        }

        internal void Generate()
        {
            _currentTail = Instantiate(_tail, _followTarget.transform.position, Quaternion.identity);
        }
    }
}