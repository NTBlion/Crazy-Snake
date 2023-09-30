using UnityEngine;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private SpawnPoint _spawnPoint;
        [SerializeField] private bool _canGenerate;

        private Tail _currentTail;

        private void Awake()
        {
            Generate();
        }

        private void Update()
        {
            if (_currentTail != null)
                _currentTail.SetPosition(_spawnPoint.transform.position);
        }

        internal void Generate()
        {
            _currentTail = Instantiate(_tail, _spawnPoint.transform.position, Quaternion.identity);
        }
    }
}