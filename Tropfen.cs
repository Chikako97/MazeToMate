using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tropfen : MonoBehaviour {

    public GameObject spawnTropfen1;
    public GameObject spawnTropfen2;

    private Vector3 startPos, endPos;
    private float distance = 20f, repeatTime = 5f;
    private float lerpTime = 10f, currentLerpTime = 0;
    private bool KeyHit = false;

    // Use this for initialization
    void Start()
    {
        //Tropfen von oben regnen lassen
        InvokeRepeating("Spawn", 0.5f, repeatTime);

        startPos = spawnTropfen1.transform.position;
        endPos = spawnTropfen1.transform.position + Vector3.forward * distance;
        startPos = spawnTropfen2.transform.position;
        endPos = spawnTropfen2.transform.position + Vector3.forward * distance;
    }

    void Spawn()
    {
        Vector3 spawnPos;

        //Spawn Mitte
        for (int i = 0; i <= 10; i++)
        {
            //ZUfällige Position der Tropfen erzeugen (In der Groesse des Feldes)
            spawnPos = new Vector3(Random.Range(1.5f, 39), 0.2f, Random.Range(0, 40));
            Instantiate(spawnTropfen1, spawnPos, Quaternion.identity);

            spawnPos = new Vector3(Random.Range(1.5f, 39), 0.2f, Random.Range(0, 40));
            Instantiate(spawnTropfen2, spawnPos, Quaternion.identity);
        }
    
    }
}
