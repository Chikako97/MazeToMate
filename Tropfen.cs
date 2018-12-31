using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tropfen : MonoBehaviour {

    public GameObject spawnTropfen1;
    public GameObject spawnTropfen2;

    private Vector3 startPos;
    private Vector3 endPos;
    private float distance = 20f;
    public float repeatTime = 5f;
    //Zeit, um von A nach B zu kommen für Bewegte Tropfen
    private float lerpTime = 10f;
    private float currentLerpTime = 0;
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
            spawnPos = new Vector3(Random.Range(1.5f, 39), -1.0f, Random.Range(6, 45));
            Instantiate(spawnTropfen1, spawnPos, Quaternion.identity);

            spawnPos = new Vector3(Random.Range(1.5f, 39), -1.0f, Random.Range(6, 45));
            Instantiate(spawnTropfen2, spawnPos, Quaternion.identity);
        }
    
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            KeyHit = true;
        }

        if (KeyHit == true)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }

            float Perc = currentLerpTime/lerpTime;
            spawnTropfen1.transform.position = Vector3.Lerp(startPos, endPos, Perc);
            spawnTropfen2.transform.position = Vector3.Lerp(startPos, endPos, Perc);

        }
    }
}
