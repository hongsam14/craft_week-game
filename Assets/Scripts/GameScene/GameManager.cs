using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(SceneController))]
//public class GameManager : MonoBehaviour

public static class GameManager
{
    //public int stageNumber { get; set; } = 1;
    public static int stageNumber { get; set; } = 0;

    public static int stageSize { get; set; } = 3;

    public static int itemNum { get; set; } = 4;

    public static uint deathCnt { get; set; } = 0;

    public static bool[,] itemlst = new bool[stageSize, itemNum];
    //private Stack<int>[] itemsStack;

    //private SceneController sceneController;
    private static SceneController sceneController;

    /*
    void Awake()
    {
        sceneController = new SceneController();
        itemsStack = new Stack<int>[3];
        for (int i = 0; i < itemsStack.Length; ++i)
            itemsStack[i] = new Stack<int>();
    }
    */
    /* 
    public void GetItems(int itemNumber)
    {
        itemsStack[stageNumber].Push(itemNumber);
    }

    public void LostItems()
    {
        itemsStack[stageNumber].Pop();
    }

    public void ChangeSence(string nextScene)
    {
        StartCoroutine(sceneController.LoadScenes(nextScene));
    }

    Stack<int>[] GetItemsStack()
    {
        return itemsStack;
    }
    */

    public static void GetItem(int itemNumber)
    {
        itemlst[stageNumber, itemNumber] = true;
    }

    public static void LostItem(int itemNumber)
    {
        itemlst[stageNumber, itemNumber] = false;
    }
}
