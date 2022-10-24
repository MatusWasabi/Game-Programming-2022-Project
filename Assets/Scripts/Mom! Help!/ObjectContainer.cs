using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectContainer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer containSpriteRenderer;
    [SerializeField] private Sprite openedSprite;
    [SerializeField] private GameObject insideObject;
    [SerializeField] private bool isOpened;

    private void Awake()
    {
        containSpriteRenderer = GetComponent<SpriteRenderer>();
        Sprite closedSprite = containSpriteRenderer.sprite;
        isOpened = false;
        insideObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked!");
        if(isOpened) { CloseContainer(); }
        else { OpenContainer(); }
        isOpened = !isOpened;
    }

    private void OpenContainer()
    {
        insideObject.SetActive(true);
    }

    private void CloseContainer()
    {
        insideObject.SetActive(false);
    }
}
