using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public GameObject endLevelUI;
    public Save saveGame;
    public GameObject text;
    public Text itemsLeftText;
    public Transform respawnTransform;

    public int levelNo;
    public int itemsToCollect;
    public int zombiesLeft;

    private void Start()
	{
        Time.timeScale = 1f;
        text.SetActive(true);
    }

    public void ZombieKilled()
    {
        zombiesLeft--;
        if (zombiesLeft <= 0)
        {
            if (itemsToCollect <= 0)
            {
                LevelCompleted();
            }
            else
                Debug.Log("You need to collect " + itemsToCollect + " ingredients.");
        }
    }

    public void IngredientCollected()
    {
        itemsToCollect--;
        int l = itemsToCollect;
        string str = l.ToString();
        itemsLeftText.text = str;

        if (itemsToCollect <= 0)
        {
            if (zombiesLeft <= 0)
            {
                LevelCompleted();
            } 
            else
                Debug.Log("You need to kill " + zombiesLeft + " zombies.");
        }
    }

    void LevelCompleted()
    {
        Debug.Log("Level Completed...");
        FindObjectOfType<AudioManager>().Play("Success");

        Scene scene = SceneManager.GetActiveScene();
        string l = scene.name;
        char last = l[l.Length - 1];
        String lvl = last.ToString();
        saveGame.SaveData(lvl);

        endLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }
}