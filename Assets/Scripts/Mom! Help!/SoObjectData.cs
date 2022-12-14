using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hidden Object", menuName = "Scriptable Object/Hidden Object Data")]
public class SoObjectData : ScriptableObject
{
    [SerializeField] private string hiddenName;
    [SerializeField] private Sprite itemSprite;
    [SerializeField] private int itemID;

    public int GetID() => itemID;
    public string GetName() => hiddenName;
    public Sprite GetSprite() => itemSprite;
}
