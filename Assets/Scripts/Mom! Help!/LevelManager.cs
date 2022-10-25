using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] private List<SoObjectData> checkList;
    [SerializeField] private List<SoObjectData> inventoryList;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) Destroy(gameObject);
    }

    public void AddToInventory(SoObjectData addedItem)
    {
        inventoryList.Add(addedItem);
        CheckEqual();
    }

    private void CheckEqual()
    {
        for (int i = 0; i < checkList.Count; i++)
        {
            if (checkList[i] == inventoryList[i])
            {
                Debug.Log("Match " + i);
            }
        }
    }

    private void AddToUi(SoObjectData soObjectData)
    {

    }
}
