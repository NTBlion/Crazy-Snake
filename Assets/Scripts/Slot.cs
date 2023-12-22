using System.Collections;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private BotInput _botInput;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private IInput _currentInput;

    public bool IsPlayerInput => false;
}