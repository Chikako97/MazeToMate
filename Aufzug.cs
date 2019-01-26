using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aufzug : MonoBehaviour
{

    public GameObject AufzugLinks;
    public GameObject AufzugRechts;
    public GameObject AufzugVorn;

    bool bewegung;
    float Gesamtzeit;
    Vector3 startPos;
    Vector3 endPos;
    Vector3 Gesamtstrecke;
    float bewegungZeit;

    // Use this for initialization
    void Start()
    {

        //Bewegung der Aufzüge
        bewegung = false;
        Gesamtzeit = 5;
        startPos = new Vector3(0, 0.09f, 0);
        endPos = new Vector3(0, 3f, 0);
        Gesamtstrecke = endPos - startPos;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !bewegung)
        {
            bewegung = true;
            bewegungZeit = Time.time;
        }

        if (bewegung)
        {
            float zeit = (Time.time - bewegungZeit) / Gesamtzeit;
            Vector3 Strecke = zeit * Gesamtstrecke;
            transform.position = startPos + Strecke;
            transform.position = startPos + Strecke;
            transform.position = startPos + Strecke;

            if (zeit >= 1)
            {
                bewegung = false;
            }
        }
    }
}