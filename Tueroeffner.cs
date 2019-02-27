using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tueroeffner : MonoBehaviour
{
    public Animation Torname;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.P))
        {
            Torname.Play();
        }
    }
}