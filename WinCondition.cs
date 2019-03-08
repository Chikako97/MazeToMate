using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {
    public LevelManager levelmanager;
    public GameObject GewonnenText;
    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spieler")
        {
            Debug.Log("Ziel erreicht");
            GameObject TomatenkumpelGameObject = GameObject.Find("Kumpel");
            GewonnenText.SetActive(true);
            levelmanager.RespawnPlayer();
        }
    }
}
