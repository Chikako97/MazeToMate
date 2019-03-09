using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpielManager : MonoBehaviour {

    public GameObject speicherpunkt;
    public GameObject Spieler;
    public int Lebensanzeige;
    public Text Lebenstext;
    public GameObject Dead;

    // Use this for initialization
    void Start()
    {
        Lebenstext.text = Lebensanzeige.ToString();
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
        Lebenstext.text = Lebensanzeige.ToString();
        //Ueberprüfung
        bool leben = Lebensanzeige > 0;

        switch (leben)
        {
            case true:
                Spieler.transform.position = speicherpunkt.transform.position;
                break;
            case false:
                Time.timeScale = 0.0f;
                Debug.Log("Game over");
                Dead.SetActive(true);
                break;
            default:
                break;
        } 
    }
}
