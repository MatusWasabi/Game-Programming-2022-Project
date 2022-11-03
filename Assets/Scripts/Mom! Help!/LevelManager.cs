using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        else if (inventoryList.Count > checkList.Count) { Debug.Log("Bug"); }


        for (int i = 0; i < checkList.Count; i++)
        {
            bool haveAll = inventoryList.Contains(checkList[i]);
            if (!haveAll) { return; }
        }

        FinishLevel();
    }



    private void FinishLevel()
    {
        Debug.Log("Level Finished!");

        int nextLevelBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCount) 
        {
        }
        else
        {
            //Move to next level
            int levelSelectionIndex = 1;

            //Setting Int for Index
            if (nextLevelBuildIndex > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextLevelBuildIndex);
            }

            SceneManager.LoadScene(levelSelectionIndex);
        }
    }

    public void ToSelection()
    {
        SceneManager.LoadScene(1);
    }
}
