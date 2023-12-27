using TNRD;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IInput> _botInput;
    [SerializeField] private SerializableInterface<IInput> _playerInput;
    [SerializeField] private SerializableInterface<IInput> _currentInput;

    public bool IsPlayerInput => false;
}