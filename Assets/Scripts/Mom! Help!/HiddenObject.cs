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
        spriteRenderer = GetComponent<SpriteRenderer>();
        itemName = itemData.GetName();
        spriteRenderer.sprite = itemData.GetSprite();
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        Destroy(gameObject);
    }

    public SoObjectData GetItemData() => itemData;
   

}
