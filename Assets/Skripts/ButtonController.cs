using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ButtonController : MonoBehaviour
{

    int levelUnlock;
    public Button[] buttons;
    
    /*public Button level2B;
    public Button level3B;
    public Button level4B;
    public Button level5B;
    public Button level6B;
    public Button level7B;
    public Button level8B;
    public Button level9B;
    public Button level10B;

    public int LevelComplete;*/

    void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("levels", 1);
        
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            
        }

        for (int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }

    }

    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }


    public void Reset()
        {
            for (int i = 1; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }
            PlayerPrefs.DeleteAll();
        }
    /*public void TestButton()
    {
        for (int i = 1; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;

        }        
        PlayerPrefs.DeleteAll();       
    }*/
    /*public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }*/

    void Update()
    {

    }
    /*void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("MainBlock") && other.CompareTag("Finish"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
                level2B.interactable = true;
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                level2B.interactable = true;
                level3B.interactable = true;
            }
            SceneManager.LoadScene(0);
            /*int next = SceneManager.GetActiveScene().buildIndex + 1;
            if (next < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(next);
            }
        }
    }*/
    
}
