using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public Activator button;
    public Material normal;
    public Material transorent;
    public bool canPush;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canPush) { 
        if (other.CompareTag("Block") || other.CompareTag("MainBlock"))
        {
            foreach(GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = normal;
                first.GetComponent<Collider>().isTrigger = false;
            }
            foreach (GameObject second in secondGroup)
            {
                second.GetComponent<Renderer>().material = transorent;
                second.GetComponent<Collider>().isTrigger = true;
            }
            GetComponent<Renderer>().material = transorent;
            button.GetComponent<Renderer>().material = normal;
            button.canPush = true;
        }
    }
    }
}
