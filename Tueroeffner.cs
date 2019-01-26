using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tueroeffner : MonoBehaviour
{
    public Animation Tor;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            Tor.Play();
        }
    }
}