using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour {

    public GameObject Spieler;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Spieler)
        {
            Spieler.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Spieler)
        {
            Spieler.transform.parent = null;
        }
    }
}
