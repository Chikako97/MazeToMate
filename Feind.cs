using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feind : MonoBehaviour {

    public LevelManager levelmanager;
    public Vector3 startPos;
    public Vector3 newPos;
    public Vector3 tempPos;
    public float speed;
    public SpriteRenderer sr;
    private bool hitable;
    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
        startPos = transform.position;
        //zufällige Geschwindigkeit
        speed = Random.Range(4f, 12f);
        sr = gameObject.GetComponent<SpriteRenderer>();
        hitable = true;
    }

    // Update is called once per frame
    void Update () {
        newPos = startPos;
        newPos.x = newPos.x + Mathf.PingPong(Time.time * speed, 5) - 3;

        transform.position = newPos;

        //Bewegung positiv
        if (newPos.x > tempPos.x)
        {
            sr.flipX = true;
        }
        else //Bewegung negativ
        {
            sr.flipX = false;
        }
        //Koordinaten aktueller Frame temporär abspeichern
        tempPos = newPos;
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Spieler" && hitable == true)
        {
            levelmanager.RespawnPlayer();
            hitable = false;
            Debug.Log("Hit");
            Debug.Log(collision.collider.GetType());
            StartCoroutine(FreezePlayer());
        }
    }
    IEnumerator FreezePlayer()
    {
        yield return new WaitForSeconds(2);
        hitable = true;
    }
}
