using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MousePosition : MonoBehaviour
{


    private void OnClick(InputValue value)
    {
        if (value.isPressed)
        {
            HandleMovement();   
        }
    }

    private void HandleMovement()
    {
    }
}
