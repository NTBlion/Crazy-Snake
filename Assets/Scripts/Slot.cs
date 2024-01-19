using TNRD;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private SerializableInterface<IInput> _botInput;
    [SerializeField] private SerializableInterface<IInput> _playerInput;
    [SerializeField] private SerializableInterface<IInput> _currentInput;

    public bool IsPlayerInput => _currentInput == _playerInput;
    
    private void Awake()
    {
        _currentInput = _botInput;
    }

    [ContextMenu(nameof(SwitchInput))]
    public void SwitchInput()
    {
        if (_currentInput == _botInput)
            _currentInput = _playerInput;
        else
            _currentInput = _botInput;
    }
}