using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;
using YG.Example;

public class LevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(next);
        }
    }
    public void Returnt()
    {
        //int next = SceneManager.GetActiveScene().buildIndex - 1;
        //if (next > SceneManager.sceneCountInBuildSettings)
        //{
            SceneManager.LoadScene(0);
        //}
    }
    public void back_to_the_top()
    {
        //int next = SceneManager.GetActiveScene().buildIndex = 0;
        //if (next > SceneManager.sceneCountInBuildSettings)
        //{
        SceneManager.LoadScene(0);
        //}
    }
    public void ExidGame()
    {
        Application.Quit();
    }
    
}
