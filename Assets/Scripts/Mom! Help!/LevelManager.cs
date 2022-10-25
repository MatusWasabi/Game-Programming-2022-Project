using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] private List<SoObjectData> checkList = new List<SoObjectData>();
    [SerializeField] private List<SoObjectData> inventoryList = new List<SoObjectData>();

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
        if (checkList.Count != inventoryList.Count) { return; }


        // Check if the inventory contains all of the checklist
        //if not, this function end. If yes, this lines below loop is called.
        for (int i = 0; i < checkList.Count; i++)
        {
            bool haveAll = inventoryList.Contains(checkList[i]);
            if (!haveAll) { return; }
        }

        Debug.Log("Called Check");
    }



    private void AddToUI(SoObjectData soObjectData)
    {

    }
}
