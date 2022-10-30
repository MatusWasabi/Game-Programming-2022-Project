using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIcon : MonoBehaviour
{
    [SerializeField] private Sprite iconImage;
    [SerializeField] private Sprite correctedIcon;
    [SerializeField] private SoObjectData itemData;
    [SerializeField] private Image image;

    private void Awake()
    {
        image = gameObject.GetComponent<Image>();
        image.sprite = itemData.GetSprite();
    }

    


}
