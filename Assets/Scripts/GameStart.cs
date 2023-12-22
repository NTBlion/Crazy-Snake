using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] private List<Slot> _slots;

    private bool HasAnyPlayer()
    {
        foreach (var slot in _slots)
        {
            if (slot.IsPlayerInput)
                return true;
        }

        return false;
    }
}