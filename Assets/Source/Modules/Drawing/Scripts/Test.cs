using UnityEngine;

namespace Drawing
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private TailDrawer _tailDrawer;

        private void Awake()
        {
            _tailDrawer.EnableDrawing();
        }
    }
}