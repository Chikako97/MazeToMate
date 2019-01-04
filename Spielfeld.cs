using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spielfeld : MonoBehaviour
{
    
    private Vector3 startPos;
    private Vector3 endPos;
    private float distance = 50f;
    public float repeatTime = 10f;
    //Zeit, um von A nach B zu kommen
    private float lerpTime = 10f;
    private float currentLerpTime = 0;
    private bool KeyHit = false;

    // Use this for initialization
    void Start()
    {
        //Bodenplatte von Welt 1 (Labyrinth Theresa K)
        GameObject unten = GameObject.CreatePrimitive(PrimitiveType.Cube);
        unten.transform.localScale = new Vector3(40, 0.2f, 40);
        unten.transform.Translate(19.91f, 0, 19.8f);

        //Bodenplatte von Welt 2 (Labyrinth Alex D)
        GameObject rechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rechts.transform.localScale = new Vector3(40, 0.2f, 40);
        rechts.transform.Translate(80, 9, 25);

        //Treppen zu Welt 2
        GameObject Trepperechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts.transform.Translate(58, 8, 21);
        GameObject Trepperechts2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts2.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts2.transform.Translate(55, 7, 21);
        GameObject Trepperechts3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts3.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts3.transform.Translate(52, 6, 21);
        GameObject Trepperechts4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts4.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts4.transform.Translate(49, 5, 21);
        GameObject Trepperechts5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts5.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts5.transform.Translate(46, 4, 21);
        GameObject Trepperechts6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts6.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts6.transform.Translate(43, 3, 21);
        GameObject Trepperechts7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts7.transform.localScale = new Vector3(2, 0.5f, 7);
        Trepperechts7.transform.Translate(40.65f, 2, 22.02f);
        GameObject Trepperechts8 = GameObject.CreatePrimitive(PrimitiveType.Cube); //Aufzug
        Trepperechts8.transform.localScale = new Vector3(1.5f, 0.5f, 3);
        Trepperechts8.transform.Translate(38.8f, 0.09f, 23.81f);


        // Treppe zu Welt 3 (Würfel Sophie O)
        GameObject Treppevorn = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn.transform.Translate(25.13f, 8, 65);
        GameObject Treppevorn2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn2.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn2.transform.Translate(25.13f, 7, 62);
        GameObject Treppevorn3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn3.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn3.transform.Translate(25.13f, 6, 59);
        GameObject Treppevorn4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn4.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn4.transform.Translate(25.13f, 5, 56);
        GameObject Treppevorn5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn5.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn5.transform.Translate(25.13f, 4, 53);
        GameObject Treppevorn6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn6.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn6.transform.Translate(25.13f, 3, 50);
        GameObject Treppevorn7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn7.transform.localScale = new Vector3(5, 0.5f, 8.5f);
        Treppevorn7.transform.Translate(25.13f, 2.21f, 44.38f);
        GameObject Treppevorn8 = GameObject.CreatePrimitive(PrimitiveType.Cube); //Aufzug
        Treppevorn8.transform.localScale = new Vector3(2, 0.5f, 1.5f);
        Treppevorn8.transform.Translate(26.63f, 0.03f, 38.92f);



        //Bodenplatte von Welt 4 (Alex T)
        GameObject links = GameObject.CreatePrimitive(PrimitiveType.Cube);
        links.transform.localScale = new Vector3(40, 0.2f, 40);
        links.transform.Translate(-44, 9, 25);
        
        //Treppe zu Welt 4
        GameObject Treppelinks = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks.transform.Translate(-22, 8, 21);
        GameObject Treppelinks2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks2.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks2.transform.Translate(-19, 7, 21);
        GameObject Treppelinks3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks3.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks3.transform.Translate(-16, 6, 21);
        GameObject Treppelinks4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks4.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks4.transform.Translate(-13, 5, 21);
        GameObject Treppelinks5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks5.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks5.transform.Translate(-9.73f, 4, 21);
        GameObject Treppelinks6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks6.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks6.transform.Translate(-6.19f, 3, 21);
        GameObject Treppelinks7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks7.transform.localScale = new Vector3(5.5f, 0.5f, 10);
        Treppelinks7.transform.Translate(-2.4f, 1.76f, 23.58f);
        GameObject Treppelinks8 = GameObject.CreatePrimitive(PrimitiveType.Cube); //Aufzug
        Treppelinks8.transform.localScale = new Vector3(1.5f, 0.5f, 4);
        Treppelinks8.transform.Translate(1.19f, 0.12f, 24.35f);
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}