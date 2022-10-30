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


        // Check if the inventory contains all of the checklist
        //if not, this function end. If yes, this lines below loop is called.
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

        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCount) /* < Change this int value to whatever your
                                                                   last level build index is on your
                                                                   build settings */
        {
            Debug.Log("You Completed ALL Levels");

            //Show Win Screen or Somethin.
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

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
