using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    [SerializeField] private Texture2D cursor;
    [SerializeField] private Texture2D cursorClicked;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;
    private PlayerInput controls;

   /* private void Awake()
    {
        controls = new PlayerInput();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
   */
    private void Start()
    {
        // controls.Mouse.Click.started += _ => StartedClick();
        //controls.Mouse.Click.performed += _ => EndedClick();
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(cursorClicked, Vector2.zero, CursorMode.Auto);
            audioSource.PlayOneShot(clip);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        }
    }

    /*private void ChangeCursor(Texture2D cursorType)
    {
        //Vector2 hotspot = new Vector2(cursorType.width / 2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

    private void StartedClick()
    {
        ChangeCursor(cursorClicked);   
    }

    private void EndedClick()
    {
        ChangeCursor(cursor);
    }
    */
}
