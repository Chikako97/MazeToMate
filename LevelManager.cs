using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public GameObject Checkpoint;
    public GameObject Spieler;
    public int Lebensanzeige;
    public Text Lebenstext;
    public GameObject Dead;

    // Use this for initialization
    void Start()
    {
        Lebenstext.text = "Leben: " +Lebensanzeige.ToString();
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Spiel wird beendet");
            Application.Quit();
        }
    }

    public void RespawnPlayer()
    {
        //abziehen
        Lebensanzeige = Lebensanzeige - 1;
        //aktualisieren
        Lebenstext.text = "Leben: " + Lebenstext.ToString();
        //Ueberprüfung
        if(Lebensanzeige > 0)
        {
            Spieler.transform.position = Checkpoint.transform.position;
        } else
        {
            Time.timeScale = 0.0f;
            Debug.Log("Game over");
            Dead.SetActive(true);
        } 
    }
}
