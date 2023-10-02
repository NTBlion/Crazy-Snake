using UnityEngine;

namespace Drawing
{
    public class TailGenerator : MonoBehaviour
    {
        [SerializeField] private Tail _tail;
        [SerializeField] private FollowTarget _followTarget;

        private void Awake()
        {
            Generate();
        }
        
        public void Generate()
        {
            Instantiate(_tail, _followTarget.transform.position, Quaternion.identity, _followTarget.transform);
        }
    }
}