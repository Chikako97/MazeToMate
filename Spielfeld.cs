using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spielfeld : MonoBehaviour
{
    GameObject Treppevorn;
    GameObject Trepperechts;
    GameObject Treppelinks;

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
        //untere Seite des Labyrints
        GameObject unten = GameObject.CreatePrimitive(PrimitiveType.Cube);
        unten.transform.localScale = new Vector3(40, 0.2f, 40);
        unten.transform.Translate(20, -1.5f, 24.9f);

        //rechte Seite des Labyrints
        GameObject rechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rechts.transform.localScale = new Vector3(40, 0.2f, 40);
        rechts.transform.Translate(80, 9, 25);
        //rechte Seite Treppen
        GameObject Trepperechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts.transform.Translate(58, 8, 21);
        //rechte Seite Treppen
        GameObject Trepperechts2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts2.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts2.transform.Translate(55, 7, 21);
        //rechte Seite Treppen
        GameObject Trepperechts3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts3.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts3.transform.Translate(52, 6, 21);
        //rechte Seite Treppen
        GameObject Trepperechts4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts4.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts4.transform.Translate(49, 5, 21);
        //rechte Seite Treppen
        GameObject Trepperechts5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts5.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts5.transform.Translate(46, 4, 21);
        //rechte Seite Treppen
        GameObject Trepperechts6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts6.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts6.transform.Translate(43, 3, 21);
        //rechte Seite Treppen
        GameObject Trepperechts7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts7.transform.localScale = new Vector3(3, 4, 5);
        Trepperechts7.transform.Translate(40.29f, 0.17f, 21);
        //rechte Seite Treppen
        GameObject Trepperechts8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts8.transform.localScale = new Vector3(3, 6, 5);
        Trepperechts8.transform.Translate(37.28f, -1.51f, 21);
        //rechte Seite Treppen
        GameObject Trepperechts9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts9.transform.localScale = new Vector3(1, 3, 5);
        Trepperechts9.transform.Translate(35.34f, -1, 21);
        //rechte Seite Treppen
        GameObject Trepperechts10 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts10.transform.localScale = new Vector3(1, 0.5f, 3);
        Trepperechts10.transform.Translate(34.34f, -1.08f, 21);

        // Treppe vorn
        GameObject Treppevorn = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn.transform.Translate(25.13f, 8, 65);
        //Treppe vorn
        GameObject Treppevorn2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn2.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn2.transform.Translate(25.13f, 7, 62);
        //Treppe vorn
        GameObject Treppevorn3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn3.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn3.transform.Translate(25.13f, 6, 59);
        //Treppe vorn
        GameObject Treppevorn4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn4.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn4.transform.Translate(25.13f, 5, 56);
        //Treppe vorn
        GameObject Treppevorn5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn5.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn5.transform.Translate(25.13f, 4, 53);
        //Treppe vorn
        GameObject Treppevorn6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn6.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn6.transform.Translate(25.13f, 3, 50);
        //Treppe vorn
        GameObject Treppevorn7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn7.transform.localScale = new Vector3(5, 4, 3);
        Treppevorn7.transform.Translate(25.13f, 0.17f, 47.29f);
        //Treppe vorn
        GameObject Treppevorn8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn8.transform.localScale = new Vector3(5, 6, 3);
        Treppevorn8.transform.Translate(25.13f, -1.51f, 43.7f);
        //Treppe vorn
        GameObject Treppevorn9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn9.transform.localScale = new Vector3(5, 3, 1);
        Treppevorn9.transform.Translate(24.87f, -1.51f, 41.71f);
        //Treppe vorn
        GameObject Treppevorn10 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn10.transform.localScale = new Vector3(3, 0.5f, 1);
        Treppevorn10.transform.Translate(25.13f, -0.69f, 40.53f);


        //linke Seite des Labyrints
        GameObject links = GameObject.CreatePrimitive(PrimitiveType.Cube);
        links.transform.localScale = new Vector3(40, 0.2f, 40);
        links.transform.Translate(-44, 9, 25);
        //linke Seite Treppen
        GameObject Treppelinks = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks.transform.Translate(-22, 8, 21);
        //rechte Seite Treppen
        GameObject Treppelinks2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks2.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks2.transform.Translate(-19, 7, 21);
        //linke Seite Treppen
        GameObject Treppelinks3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks3.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks3.transform.Translate(-16, 6, 21);
        //linke Seite Treppen
        GameObject Treppelinks4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks4.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks4.transform.Translate(-13, 5, 21);
        //linke Seite Treppen
        GameObject Treppelinks5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks5.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks5.transform.Translate(-9.73f, 4, 21);
        //linke Seite Treppen
        GameObject Treppelinks6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks6.transform.localScale = new Vector3(3, 0.5f, 5);
        Treppelinks6.transform.Translate(-6.19f, 3, 21);
        //linke Seite Treppen
        GameObject Treppelinks7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks7.transform.localScale = new Vector3(3, 4, 5);
        Treppelinks7.transform.Translate(-2.67f, 0.17f, 21);
        //linke Seite Treppen
        GameObject Treppelinks8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks8.transform.localScale = new Vector3(3, 6, 5);
        Treppelinks8.transform.Translate(1, -1.51f, 21);
        //linke Seite Treppen
        GameObject Treppelinks9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks9.transform.localScale = new Vector3(1, 3, 3);
        Treppelinks9.transform.Translate(3.31f, -1, 21);
        //linke Seite Treppen
        GameObject Treppelinks10 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppelinks10.transform.localScale = new Vector3(1, 0.5f, 3);
        Treppelinks10.transform.Translate(4.34f, -1.08f, 21);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
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

            float Perc = currentLerpTime / lerpTime;
            Trepperechts.transform.position = Vector3.Lerp(startPos, endPos, Perc);
            Trepperechts.transform.position = Vector3.Lerp(startPos, endPos, Perc);

        }
    }
}