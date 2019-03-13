using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeindZ : MonoBehaviour
{

    public SpielManager spielmanager;
    public Vector3 startPos, Pos2, Pos1;
    public float Geschwindigkeit;
    private bool verletzt;
    // Use this for initialization
    void Start()
    {
        spielmanager = FindObjectOfType<SpielManager>();
        startPos = transform.position;
        //zufällige Geschwindigkeit
        Geschwindigkeit = Random.Range(2f, 4f);
        verletzt = true;
    }

    // Update is called once per frame
    void Update()
    {
        Pos2 = startPos;
        Pos2.z = Pos2.z + Mathf.PingPong(Time.time * Geschwindigkeit, 4) - 2;
        transform.position = Pos2;

        //Koordinaten aktueller Frame temporär abspeichern
        Pos1 = Pos2;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spieler" && verletzt == true)
        {
            spielmanager.RespawnPlayer();
            verletzt = false;
            Debug.Log("Hit");
            Debug.Log(collision.collider.GetType());
            StartCoroutine(FreezePlayer());
        }
    }

    //https://www.youtube.com/watch?v=GOKzrEioYeM&list=PLVGTm2ujeFKTOylxzHjB1uZSLLyZMWAaw&index=17
    IEnumerator FreezePlayer()
    {
        yield return new WaitForSeconds(2);
        verletzt = true;
    }
}
