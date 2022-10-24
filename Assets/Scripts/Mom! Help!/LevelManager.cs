using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] private List<HiddenObjectsData> hiddenObjectsList;
    [SerializeField] private List<HiddenObjectsData> activeHiddenObjectList;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) Destroy(gameObject);
    }

    private void AssignHiddenObjects()
    {
        for (int i = 0; i < hiddenObjectsList.Count; i++)
        {
            hiddenObjectsList[i].hiddenObject.GetComponent<Collider2D>().enabled = false;
        }
    }

}

[System.Serializable]
public class HiddenObjectsData
{
    public string name;
    public GameObject hiddenObject;
    public bool makeHidden = false;
}