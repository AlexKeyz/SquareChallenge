using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class Player1 : MonoBehaviour
{
    
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] KeyCode keyOne2;
    [SerializeField] KeyCode keyTwo2;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] KeyCode keyOneV;
    [SerializeField] KeyCode keyTwoV;
    [SerializeField] KeyCode keyOne2V;
    [SerializeField] KeyCode keyTwo2V;
    [SerializeField] Vector3 moveDirectionV;
    [SerializeField] KeyCode Esc;
    [SerializeField] AudioSource levelcompleataudio;
    int SaveLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        /*if (YandexGame.SDKEnabled == true)
        {
            LeveLoading();
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyOne2))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyTwo2))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyOneV))
        {
            GetComponent<Rigidbody>().velocity += moveDirectionV;
        }
        if (Input.GetKey(keyTwoV))
        {
            GetComponent<Rigidbody>().velocity -= moveDirectionV;
        }
        if (Input.GetKey(keyOne2V))
        {
            GetComponent<Rigidbody>().velocity += moveDirectionV;
        }
        if (Input.GetKey(keyTwo2V))
        {
            GetComponent<Rigidbody>().velocity -= moveDirectionV;
        }
        if (Input.GetKey(Esc))
        {
            SceneManager.LoadScene(0);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("MainBlock") && other.CompareTag("Finish"))
        {
            levelcompleataudio.Play();
            UnLockLevel();
            Invoke("MenuExit", 1f);
            //StartCoroutine(MenuExit());
            /*int next = SceneManager.GetActiveScene().buildIndex + 1;
            if (next < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(next);
            }*/
            //if (SceneManager.GetActiveScene().buildIndex == 1)
                        //   level2B.interactable = true;
        }
        if (this.CompareTag("Block") && other.CompareTag("Block"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = false;
            }
        }

        
    }
    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Block") && other.CompareTag("Block"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = true;
            }
           
        }
        
    }

    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
            SaveLevel = SceneManager.GetActiveScene().buildIndex;
            MySave();
        }
    }
    

    public void MenuExit()
    {
        //int next = SceneManager.GetActiveScene().buildIndex + 1;
        /*if (SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 10)
        {
            Invoke("Advert", 0.5f);
            //YandexGame.FullscreenShow();
        }*/
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(next);
        }
        /*if (SceneManager.GetActiveScene().buildIndex < 10)
        {
            SceneManager.LoadScene(next);
        }*/
        else
        {
            SceneManager.LoadScene(0);
        }
        YandexGame.FullscreenShow();
    }
    public void MySave()
    {
        YandexGame.savesData.money = SaveLevel;
        YandexGame.SaveProgress();
    }
    public void LeveLoading()
    { 
        PlayerPrefs.SetInt("levels", SaveLevel);
    }
    public void Advert()
    {
        YandexGame.FullscreenShow();
    }
}
