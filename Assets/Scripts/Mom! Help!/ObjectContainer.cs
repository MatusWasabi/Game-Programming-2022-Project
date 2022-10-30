using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectContainer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer containSpriteRenderer;
    [SerializeField] private Sprite openedSprite;
    [SerializeField] private Sprite closedSprite;
    [SerializeField] private GameObject insideObject;
    [SerializeField] private bool isOpened;

    private void Awake()
    {
        containSpriteRenderer = GetComponent<SpriteRenderer>();
        Sprite closedSprite = containSpriteRenderer.sprite;
        isOpened = false;
        if(insideObject != null) { insideObject.SetActive(false); }
        
    }

    private void OnMouseDown()
    {
        if(isOpened) { CloseContainer(); }
        else { OpenContainer(); }
        isOpened = !isOpened;
    }

    private void OpenContainer()
    {
        if (insideObject != null) { insideObject.SetActive(true); }
        containSpriteRenderer.sprite = openedSprite;
    }

    private void CloseContainer()
    {
        if (insideObject != null) { insideObject.SetActive(false); }
        containSpriteRenderer.sprite = closedSprite;
    }
}
