using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public LevelManager levelCheckpoint;
	// Use this for initialization
	void Start () {
        levelCheckpoint = FindObjectOfType<LevelManager> ();
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
            levelCheckpoint.Checkpoint = gameObject;
        }
    }
}
