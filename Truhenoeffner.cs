using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truhenoeffner : MonoBehaviour {

    public Animation Truhe;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.O))
        {
            Truhe.Play();
        }
    }
}
