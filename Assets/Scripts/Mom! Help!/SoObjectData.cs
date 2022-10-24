using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hidden Object", menuName = "Scriptable Object/Hidden Object Data")]
public class SoObjectData : ScriptableObject
{
    public string hiddenName;
    public Sprite itemSprite;

}
