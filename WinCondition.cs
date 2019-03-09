using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {
    public SpielManager spielmanager;
    public GameObject GewonnenText;
    // Use this for initialization
    void Start()
    {
        spielmanager = FindObjectOfType<SpielManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spieler")
        {
            Debug.Log("Ziel erreicht");
            GameObject TomatenkumpelGameObject = GameObject.Find("Kumpel");
            GewonnenText.SetActive(true);
            spielmanager.RespawnPlayer();
        }
    }
}
