using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sammeln : MonoBehaviour
{
    public GameObject ps;
    public GameObject ps1;

    GameObject Tropfen;

    GameObject RotSchluessel;
    GameObject GruenSchluessel;
    GameObject BlauSchluessel;
    GameObject GelbSchluessel;
    GameObject VioletSchluessel;
    GameObject CyanSchluessel;
    GameObject WeissSchluessel;

    int TropfenStatus = 0;
    public Material blau;
    public Material rot;

    // Funktion, um Tropfen aufzusammeln und Farbe auf Blau zu ändern
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tropfen"))
        {
            other.gameObject.SetActive(false);
            Instantiate(ps, transform.position, Quaternion.identity);
            gameObject.GetComponent<Renderer>().material = blau;

        } else {
            gameObject.GetComponent<Renderer>().material = rot;
        }

        if (other.gameObject.CompareTag("Schluessel"))
        {
            other.gameObject.SetActive(false);
            Instantiate(ps1, transform.position, Quaternion.identity);
        }
    }
}