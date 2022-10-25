using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Users;

public class GamepadCursor : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private RectTransform curcerTransform;
    [SerializeField] private float Curserspeed = 1000f;
    [SerializeField] private RectTransform canvasTransform;
    [SerializeField] private Canvas canvas;

    private Camera mainCamera;
    private Mouse virtualMouse;
    private bool previousMouseState;


    private void OnEnable()
    {
        mainCamera = Camera.main;   

        if(virtualMouse == null)
        {
            virtualMouse = (Mouse) InputSystem.AddDevice("VirtualMouse");  
        }
        else if(!virtualMouse.added){
            InputSystem.AddDevice(virtualMouse);
        }

        InputUser.PerformPairingWithDevice(virtualMouse, playerInput.user);

        if (curcerTransform != null)
        {
            Vector2 position = curcerTransform.anchoredPosition;
            InputState.Change(virtualMouse.position, position);
        }
        InputSystem.onAfterUpdate += UpdateMotion;
    }

    private void OnDisable()
    {
        InputSystem.onAfterUpdate -= UpdateMotion;
    }
    private void UpdateMotion()
    {
        if(virtualMouse != null || Gamepad.current == null)
        {
            return;
        }

        Vector2 stickValue = Gamepad.current.leftStick.ReadValue();
        stickValue *= Curserspeed * Time.deltaTime;

        Vector2 currentPosition = virtualMouse.position.ReadValue();
        Vector2 newPosition = currentPosition + stickValue;

        newPosition.x = Mathf.Clamp(newPosition.x, 0, Screen.width);
        newPosition.y = Mathf.Clamp(newPosition.y, 0, Screen.height);

        InputState.Change(virtualMouse.position, newPosition);
        InputState.Change(virtualMouse.delta, stickValue);


        bool aButtonIspressed = Gamepad.current.aButton.IsPressed();
        if(previousMouseState != Gamepad.current.aButton.isPressed)
        {
            virtualMouse.CopyState<MouseState>(out var mouseState);
            mouseState.WithButton(MouseButton.Left, aButtonIspressed);
            InputState.Change(virtualMouse, mouseState);
            previousMouseState = aButtonIspressed;
        }

        AnchorCursor(newPosition);

    }

    private void AnchorCursor(Vector2 position)
    {
        Vector2 anchordPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle
            (
             canvasTransform, 
             position, 
             canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : mainCamera, out anchordPosition
            );
        curcerTransform.anchoredPosition = anchordPosition;
    }
}
