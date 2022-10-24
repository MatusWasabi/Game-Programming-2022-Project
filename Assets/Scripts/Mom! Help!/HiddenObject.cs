using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject : MonoBehaviour
{
    [SerializeField] private SoObjectData itemData;

    [SerializeField] private SpriteRenderer spriteRenderer;
    
    private string itemName;
    private Sprite itemSprite;

    private void Awake()
    {
        itemName = itemData.hiddenName;
        spriteRenderer.sprite = itemData.itemSprite;
    }

    private void OnMouseDown()
    {
        Debug.Log("Found");
    }

}
