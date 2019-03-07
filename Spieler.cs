using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spieler : MonoBehaviour
{
    bool bewegung;
    float jump;
    private bool isDead;
    float translateFaktor = 3;
    float rotateFaktor = 100;
    [SerializeField] Rigidbody rb;
    public GameObject Gameover;

    private int TropfenZaehler;
    public Text TropfenText;
    public Text highscoreText;

    void Start () {
        bewegung = false;
        isDead = false;
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
                rb.AddForce(0, 3.5f, 0, ForceMode.Impulse);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Abgrund") {
            RaycastHit hit;

            Ray down = new Ray(transform.position, -Vector3.up);

            if (!Physics.Raycast(down, out hit))
            {
                isDead = true;
                Gameover.SetActive(true);
                transform.GetChild(0).transform.parent = null;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Tropfen")
            {
             TropfenZaehler++;
             TropfenText.text = "Tropfen: " + TropfenZaehler.ToString();
             Debug.Log("Tropfen: " + TropfenZaehler);

             if(TropfenZaehler > PlayerPrefs.GetInt("Highscore"))
             {
                PlayerPrefs.SetInt("Highscore", TropfenZaehler);
                highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
            }
        }   
    }
}
