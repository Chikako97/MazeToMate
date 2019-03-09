using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sammeln : MonoBehaviour
{
    public GameObject ps;

    GameObject Tropfen;

    int TropfenStatus = 0;
    public Material blau;
    public Material rot;

    // Funktion, um Tropfen aufzusammeln und Farbe auf Blau zu ändern
    void OnTriggerEnter(Collider other)
    {
        bool sammeln = other.gameObject.CompareTag("Tropfen");

        switch (sammeln)
        {
            case true:
                other.gameObject.SetActive(false);
                Instantiate(ps, transform.position, Quaternion.identity);
                gameObject.GetComponent<Renderer>().material = blau;
                break;
            case false:
                gameObject.GetComponent<Renderer>().material = rot;
                break;
            default:
                break;
        }
    }
}