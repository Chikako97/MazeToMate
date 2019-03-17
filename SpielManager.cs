using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpielManager : MonoBehaviour {

    public GameObject speicherpunkt, Spieler, Dead;
    public int Lebensanzeige;
    public Text Lebenstext;

    // Use this for initialization
    void Start()
    {
        Lebenstext.text = Lebensanzeige.ToString();
    }

    public void RespawnPlayer()
    {
        Lebensanzeige = Lebensanzeige - 1;
        Lebenstext.text = Lebensanzeige.ToString();

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
