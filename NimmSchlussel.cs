﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NimmSchlussel : MonoBehaviour {

    public Component torschlussel;
    public GameObject Schlussel;
    public GameObject Besitz;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay () {
        if (Input.GetKey(KeyCode.P))
        {
            torschlussel.GetComponent<BoxCollider>().enabled = true;
        }
        
        if (Input.GetKey(KeyCode.P))
        {
            Schlussel.SetActive(false);
            Besitz.SetActive(true);
        }       
	}
}
