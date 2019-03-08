using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neustart : MonoBehaviour {
    public LevelManager levelmanager;
    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Spieler")
        {
            Debug.Log("Tod");
            levelmanager.RespawnPlayer();
        } else
        {
            Debug.Log("Es ist  nicht der Spieler");
        }
    }
}
