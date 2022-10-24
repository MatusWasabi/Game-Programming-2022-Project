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
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector3.zero);

        if (hit)
        {
            
        }
    }
}
