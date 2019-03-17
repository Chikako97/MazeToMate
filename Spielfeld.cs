using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spielfeld : MonoBehaviour
{
    public Material Treppe, boden;
    Shader shader;
    Texture texture;
    Color color;

    // Use this for initialization
    void Start()
    {
        //Bodenplatte von Welt 1 (Labyrinth Theresa K)
        GameObject unten = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend = unten.GetComponent<MeshRenderer>();
        rend.material = new Material(Shader.Find("Specular"));
        rend.material = boden;
        unten.transform.localScale = new Vector3(40, 0.2f, 40);
        unten.transform.Translate(19.91f, 0, 20);


        //Start Welt 2
        GameObject plattform = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend0 = plattform.GetComponent<MeshRenderer>();
        rend0.material = new Material(Shader.Find("Specular"));
        rend0.material = boden;
        plattform.transform.localScale = new Vector3(8, 0.5f, 8);
        plattform.transform.Translate(63.59f, 8.5f, 21);

        //Treppen von Welt 2 (Labyrinth Alex T)
        GameObject Trepperechts = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend1 = Trepperechts.GetComponent<MeshRenderer>();
        rend1.material = new Material(Shader.Find("Specular"));
        rend1.material = Treppe;
        Trepperechts.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts.transform.Translate(58, 7.8f, 21);
        GameObject Trepperechts2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend2 = Trepperechts2.GetComponent<MeshRenderer>();
        rend2.material = new Material(Shader.Find("Specular"));
        rend2.material = Treppe;
        Trepperechts2.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts2.transform.Translate(55, 7, 21);
        GameObject Trepperechts3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend3 = Trepperechts3.GetComponent<MeshRenderer>();
        rend3.material = new Material(Shader.Find("Specular"));
        rend3.material = Treppe;
        Trepperechts3.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts3.transform.Translate(52, 6.2f, 21);
        GameObject Trepperechts4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend4 = Trepperechts4.GetComponent<MeshRenderer>();
        rend4.material = new Material(Shader.Find("Specular"));
        rend4.material = Treppe;
        Trepperechts4.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts4.transform.Translate(49, 5.4f, 21);
        GameObject Trepperechts5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend5 = Trepperechts5.GetComponent<MeshRenderer>();
        rend5.material = new Material(Shader.Find("Specular"));
        rend5.material = Treppe;
        Trepperechts5.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts5.transform.Translate(46, 4.6f, 21);
        GameObject Trepperechts6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend6 = Trepperechts6.GetComponent<MeshRenderer>();
        rend6.material = new Material(Shader.Find("Specular"));
        rend6.material = Treppe;
        Trepperechts6.transform.localScale = new Vector3(3, 0.5f, 5);
        Trepperechts6.transform.Translate(43, 3.8f, 21);
        GameObject Trepperechts7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend7 = Trepperechts7.GetComponent<MeshRenderer>();
        rend7.material = new Material(Shader.Find("Specular"));
        rend7.material = Treppe;
        Trepperechts7.transform.localScale = new Vector3(1.5f, 0.5f, 7);
        Trepperechts7.transform.Translate(40.54f, 3.063f, 21.69f);


        // Treppe zu Welt 3 (Würfel Sophie O)
        GameObject Treppevorn = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend10 = Treppevorn.GetComponent<MeshRenderer>();
        rend10.material = new Material(Shader.Find("Specular"));
        rend10.material = boden;
        Treppevorn.transform.localScale = new Vector3(15, 0.5f, 30);
        Treppevorn.transform.Translate(19.39f, -10.2f, 73.76f);

        GameObject Treppevorn1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend11 = Treppevorn1.GetComponent<MeshRenderer>();
        rend11.material = new Material(Shader.Find("Specular"));
        rend11.material = Treppe;
        Treppevorn1.transform.localScale = new Vector3(6, 0.5f, 3);
        Treppevorn1.transform.Translate(30.07f, 7.73f, 65.1f);
        GameObject Treppevorn2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend12 = Treppevorn2.GetComponent<MeshRenderer>();
        rend12.material = new Material(Shader.Find("Specular"));
        rend12.material = Treppe;
        Treppevorn2.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn2.transform.Translate(29.09f, 7, 62);
        GameObject Treppevorn3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend13 = Treppevorn3.GetComponent<MeshRenderer>();
        rend13.material = new Material(Shader.Find("Specular"));
        rend13.material = Treppe;
        Treppevorn3.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn3.transform.Translate(27.32f, 6, 59);
        GameObject Treppevorn4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend14 = Treppevorn4.GetComponent<MeshRenderer>();
        rend14.material = new Material(Shader.Find("Specular"));
        rend14.material = Treppe;
        Treppevorn4.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn4.transform.Translate(26.18f, 5, 56);
        GameObject Treppevorn5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend15 = Treppevorn5.GetComponent<MeshRenderer>();
        rend15.material = new Material(Shader.Find("Specular"));
        rend15.material = Treppe;
        Treppevorn5.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn5.transform.Translate(25.15f, 4, 53);
        GameObject Treppevorn6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend16 = Treppevorn6.GetComponent<MeshRenderer>();
        rend16.material = new Material(Shader.Find("Specular"));
        rend16.material = Treppe;
        Treppevorn6.transform.localScale = new Vector3(5, 0.5f, 3);
        Treppevorn6.transform.Translate(24.4f, 3.5f, 50);
        GameObject Treppevorn7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend17 = Treppevorn7.GetComponent<MeshRenderer>();
        rend17.material = new Material(Shader.Find("Specular"));
        rend17.material = Treppe;
        Treppevorn7.transform.localScale = new Vector3(5, 0.5f, 9);
        Treppevorn7.transform.Translate(25.55f, 3.0f, 44.08f);
    }
}
