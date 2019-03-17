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


        //Start Welt 2
        /*GameObject boden = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend2 = boden.GetComponent<Renderer>();
        rend2.material = new Material(Shader.Find("Specular"));
        rend2.material.SetColor("_Color", Color.green);
        boden.transform.localScale = new Vector3(8, 0.5f, 8);
        boden.transform.Translate(63.59f, 8.5f, 21);*/

        //Treppen von Welt 2 (Labyrinth Alex T)
        GameObject Trepperechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend1 = Trepperechts.GetComponent<Renderer>();
        rend1.material = new Material(Shader.Find("Specular"));
        rend1.material.SetColor("_Color", Color.gray);
        Trepperechts.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts.transform.Translate(58, 7.8f, 21);
        GameObject Trepperechts2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend2 = Trepperechts2.GetComponent<Renderer>();
        rend2.material = new Material(Shader.Find("Specular"));
        rend2.material.SetColor("_Color", Color.gray);
        Trepperechts2.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts2.transform.Translate(55, 7, 21);
        GameObject Trepperechts3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend3 = Trepperechts3.GetComponent<Renderer>();
        rend3.material = new Material(Shader.Find("Specular"));
        rend3.material.SetColor("_Color", Color.gray);
        Trepperechts3.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts3.transform.Translate(52, 6.2f, 21);
        GameObject Trepperechts4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend4 = Trepperechts4.GetComponent<Renderer>();
        rend4.material = new Material(Shader.Find("Specular"));
        rend4.material.SetColor("_Color", Color.gray);
        Trepperechts4.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts4.transform.Translate(49, 5.4f, 21);
        GameObject Trepperechts5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend5 = Trepperechts5.GetComponent<Renderer>();
        rend5.material = new Material(Shader.Find("Specular"));
        rend5.material.SetColor("_Color", Color.gray);
        Trepperechts5.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts5.transform.Translate(46, 4.6f, 21);
        GameObject Trepperechts6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend6 = Trepperechts6.GetComponent<Renderer>();
        rend6.material = new Material(Shader.Find("Specular"));
        rend6.material.SetColor("_Color", Color.gray);
        Trepperechts6.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts6.transform.Translate(43, 3.8f, 21);
        GameObject Trepperechts7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend7 = Trepperechts7.GetComponent<Renderer>();
        rend7.material = new Material(Shader.Find("Specular"));
        rend7.material.SetColor("_Color", Color.gray);
        Trepperechts7.transform.localScale = new Vector3(1.5f, 0.5f, 7);
        Trepperechts7.transform.Translate(40.54f, 3.063f, 21.69f);


        // Treppe zu Welt 3 (Würfel Sophie O)
        GameObject Treppevorn = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend0 = Treppevorn.GetComponent<Renderer>();
        rend0.material = new Material(Shader.Find("Specular"));
        rend0.material.SetColor("_Color", Color.green);
        Treppevorn.transform.localScale = new Vector3(15, 0.5f, 30);
        Treppevorn.transform.Translate(19.39f, -10.2f, 73.76f);

        GameObject Treppevorn1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend11 = Treppevorn1.GetComponent<Renderer>();
        rend11.material = new Material(Shader.Find("Specular"));
        rend11.material.SetColor("_Color", Color.gray);
        Treppevorn1.transform.localScale = new Vector3(6, 0.5f, 3);
        Treppevorn1.transform.Translate(30.07f, 7.73f, 65.1f);
        GameObject Treppevorn2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend12 = Treppevorn2.GetComponent<Renderer>();
        rend12.material = new Material(Shader.Find("Specular"));
        rend12.material.SetColor("_Color", Color.gray);
        Treppevorn2.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn2.transform.Translate(29.09f, 7, 62);
        GameObject Treppevorn3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend13 = Treppevorn3.GetComponent<Renderer>();
        rend13.material = new Material(Shader.Find("Specular"));
        rend13.material.SetColor("_Color", Color.gray);
        Treppevorn3.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn3.transform.Translate(27.32f, 6, 59);
        GameObject Treppevorn4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend14 = Treppevorn4.GetComponent<Renderer>();
        rend14.material = new Material(Shader.Find("Specular"));
        rend14.material.SetColor("_Color", Color.gray);
        Treppevorn4.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn4.transform.Translate(26.18f, 5, 56);
        GameObject Treppevorn5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend15 = Treppevorn5.GetComponent<Renderer>();
        rend15.material = new Material(Shader.Find("Specular"));
        rend15.material.SetColor("_Color", Color.gray);
        Treppevorn5.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn5.transform.Translate(25.15f, 4, 53);
        GameObject Treppevorn6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend16 = Treppevorn6.GetComponent<Renderer>();
        rend16.material = new Material(Shader.Find("Specular"));
        rend16.material.SetColor("_Color", Color.gray);
        Treppevorn6.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn6.transform.Translate(24.4f, 3.5f, 50);
        GameObject Treppevorn7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend17 = Treppevorn7.GetComponent<Renderer>();
        rend17.material = new Material(Shader.Find("Specular"));
        rend17.material.SetColor("_Color", Color.gray);
        Treppevorn7.transform.localScale = new Vector3(5, 0.5f, 9);
        Treppevorn7.transform.Translate(25.55f, 3.0f, 44.08f);
    }
}
