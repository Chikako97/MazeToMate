﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public LevelManager levelmanager;
	// Use this for initialization
	void Start () {
        levelmanager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Spieler")
        {
            Debug.Log("Checkpoint erreicht");
            //Checkpoint speichern
            levelmanager.Checkpoint = gameObject;
        }
    }
}