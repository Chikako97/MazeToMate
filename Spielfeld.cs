using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spielfeld : MonoBehaviour
{
    Shader shader;
    Texture texture;
    Color color;

    // Use this for initialization
    void Start()
    {
        //Bodenplatte von Welt 1 (Labyrinth Theresa K)
        GameObject unten = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend = unten.GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Specular"));
        rend.material.SetColor("_Color", Color.green);
        unten.transform.localScale = new Vector3(40, 0.2f, 40);
        unten.transform.Translate(19.91f, 0, 19.8f);


        /*  //Find the Specular shader and change its Color to red
          rend.material.shader = Shader.Find("Specular");
          rend.material.SetColor("_SpecColor", Color.red); */

        //Start Welt 2
        GameObject boden = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend2 = boden.GetComponent<Renderer>();
        rend2.material = new Material(Shader.Find("Specular"));
        rend2.material.SetColor("_Color", Color.green);
        boden.transform.localScale = new Vector3(8, 0.5f, 8);
        boden.transform.Translate(63.59f, 8.5f, 21);

        //Treppen von Welt 2 (Labyrinth Alex T)
        GameObject Trepperechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts.transform.Translate(58, 7.8f, 21);
        GameObject Trepperechts2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts2.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts2.transform.Translate(55, 7, 21);
        GameObject Trepperechts3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts3.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts3.transform.Translate(52, 6.2f, 21);
        GameObject Trepperechts4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts4.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts4.transform.Translate(49, 5.4f, 21);
        GameObject Trepperechts5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts5.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts5.transform.Translate(46, 4.6f, 21);
        GameObject Trepperechts6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts6.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts6.transform.Translate(43, 3.8f, 21);
        GameObject Trepperechts7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Trepperechts7.transform.localScale = new Vector3(1.5f, 0.5f, 7);
        Trepperechts7.transform.Translate(40.54f, 3.063f, 21.69f);


        // Treppe zu Welt 3 (Würfel Sophie O)
        GameObject Treppevorn = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend3 = Treppevorn.GetComponent<Renderer>();
        rend3.material = new Material(Shader.Find("Specular"));
        rend3.material.SetColor("_Color", Color.green);
        Treppevorn.transform.localScale = new Vector3(15, 0.5f, 30);
        Treppevorn.transform.Translate(19.39f, -10.2f, 73.76f);

        GameObject Treppevorn1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn1.transform.localScale = new Vector3(6, 0.5f, 3);
        Treppevorn1.transform.Translate(30.07f, 7.73f, 65.1f);
        GameObject Treppevorn2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn2.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn2.transform.Translate(29.09f, 7, 62);
        GameObject Treppevorn3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn3.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn3.transform.Translate(27.32f, 6, 59);
        GameObject Treppevorn4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn4.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn4.transform.Translate(26.18f, 5, 56);
        GameObject Treppevorn5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn5.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn5.transform.Translate(25.15f, 4, 53);
        GameObject Treppevorn6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn6.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn6.transform.Translate(24.4f, 3, 50);
        GameObject Treppevorn7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Treppevorn7.transform.localScale = new Vector3(3, 0.5f, 8);
        Treppevorn7.transform.Translate(25.2f, 3.27f, 50);

        /*//Treppe von Welt 4 (Alex D)

       GameObject Treppelinks = GameObject.CreatePrimitive(PrimitiveType.Cube);
       //var boxCollider = (BoxCollider)Treppelinks.collider;
       //boxCollider.center = new Vector3(2, 3, 4);
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
       Treppelinks6.transform.localScale = new Vector3(8.5f, 0.5f, 7);
       Treppelinks6.transform.Translate(-4.08f, 3, 22.23f); */
    }
}
