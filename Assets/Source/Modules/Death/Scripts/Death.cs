using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    public event Action Died; 
    
    public void Die()
    {
        Died?.Invoke();
        Debug.Log("I died");
    }
}
