using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spieler : MonoBehaviour
{
    bool bewegung;
    float jump;
    private bool tot;
    float translateFaktor = 2.5f, rotateFaktor = 80;
    [SerializeField] Rigidbody rb;
    public GameObject Gameover;

    private int TropfenZaehler;
    public Text TropfenText, highscoreText;

    void Start () {
        bewegung = false;
        tot = false;
        TropfenZaehler = 0;
        // lade Highscore
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

        // Update is called once per frame
    void FixedUpdate () {
        if (!bewegung)
        {
        transform.Translate(new Vector3(0, 0, translateFaktor * Time.deltaTime * Input.GetAxis("Vertical")));
        transform.Rotate(new Vector3(0, rotateFaktor * Time.deltaTime * Input.GetAxis("Horizontal"), 0));

            if (Input.GetButtonUp("Jump"))
            {
                rb.AddForce(0, 5.2f, 0, ForceMode.Impulse);
            }
        }
    }

    //Tod des Spielers und Kamera stop
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Abgrund") {
            RaycastHit kill;

            Ray abgrund = new Ray(transform.position, -Vector3.up);

            if (!Physics.Raycast(abgrund, out kill))
            {
                tot = true;
                Gameover.SetActive(true);
                transform.GetChild(0).transform.parent = null;
            }
        }
    }

    //Topfenzaehler und Highscore Anzeige
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Tropfen")
        {
             TropfenZaehler++;
             TropfenText.text = TropfenZaehler.ToString();
             Debug.Log(TropfenZaehler);

             if(TropfenZaehler > PlayerPrefs.GetInt("Highscore"))
             {
                PlayerPrefs.SetInt("Highscore", TropfenZaehler);
                highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
            }
        }   
    }
}
