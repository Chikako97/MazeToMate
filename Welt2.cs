using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welt2 : MonoBehaviour {

    //public GameObject start;
    public GameObject base1;
    public GameObject base2;
    public GameObject base3;
    public GameObject base4;
    public GameObject base5;
    public GameObject base6;
    public GameObject base7;
    public GameObject base8;
    public GameObject hinderniss1;
    public GameObject hinderniss2;
    //public GameObject end;
    //Shader shader;
    //Texture texture;
    //Color color;

    void Start()
    {
       
        /*GameObject start = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend = start.GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Specular"));
        rend.material.SetColor("_Color", Color.red);
        start.transform.localScale = new Vector3(3,0.5f,3);
        start.transform.Translate(49.13f, 8.56f, 81.88f);*/

        GameObject base1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend1 = base1.GetComponent<Renderer>();
        rend1.material = new Material(Shader.Find("Specular"));
        rend1.material.SetColor("_Color", Color.green);
        base1.transform.localScale = new Vector3(3, 0.5f, 3);
        base1.transform.Translate(64.173f, 8.56f, 81.883f);

        GameObject base2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend2 = base2.GetComponent<Renderer>();
        rend2.material = new Material(Shader.Find("Specular"));
        rend2.material.SetColor("_Color", Color.green);
        base2.transform.localScale = new Vector3(3, 0.5f, 3);
        base2.transform.Translate(64.16f, 8.56f, 101);

        GameObject base3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend3 = base3.GetComponent<Renderer>();
        rend3.material = new Material(Shader.Find("Specular"));
        rend3.material.SetColor("_Color", Color.green);
        base3.transform.localScale = new Vector3(3, 0.5f, 3);
        base3.transform.Translate(92.135f, 8.56f, 101);

        GameObject base4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend4 = base4.GetComponent<Renderer>();
        rend4.material = new Material(Shader.Find("Specular"));
        rend4.material.SetColor("_Color", Color.green);
        base4.transform.localScale = new Vector3(3, 0.5f, 3);
        base4.transform.Translate(98.14f, 14.56f, 101);

        GameObject base5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend5 = base5.GetComponent<Renderer>();
        rend5.material = new Material(Shader.Find("Specular"));
        rend5.material.SetColor("_Color", Color.green);
        base5.transform.localScale = new Vector3(3, 0.5f, 3);
        base5.transform.Translate(116.235f, 14.56f, 101);

        GameObject base6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend6 = base6.GetComponent<Renderer>();
        rend6.material = new Material(Shader.Find("Specular"));
        rend6.material.SetColor("_Color", Color.green);
        base6.transform.localScale = new Vector3(3, 0.5f, 3);
        base6.transform.Translate(116.135f, 8.56f, 76.19f);

        GameObject base7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend7 = base7.GetComponent<Renderer>();
        rend7.material = new Material(Shader.Find("Specular"));
        rend7.material.SetColor("_Color", Color.green);
        base7.transform.localScale = new Vector3(3, 0.5f, 3);
        base7.transform.Translate(149.145f, 8.56f, 76.19f);

        GameObject base8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend8 = base8.GetComponent<Renderer>();
        rend8.material = new Material(Shader.Find("Specular"));
        rend8.material.SetColor("_Color", Color.green);
        base8.transform.localScale = new Vector3(3, 0.5f, 3);
        base8.transform.Translate(169.135f, 8.56f, 107.31f);

        GameObject hinderniss1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend9 = hinderniss1.GetComponent<Renderer>();
        rend9.material = new Material(Shader.Find("Specular"));
        rend9.material.SetColor("_Color", Color.magenta);
        hinderniss1.transform.localScale = new Vector3(0.4f, 0.5f, 3);
        hinderniss1.transform.Translate(80.8f, 9.1f, 101);

        GameObject hinderniss2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend10 = hinderniss2.GetComponent<Renderer>();
        rend10.material = new Material(Shader.Find("Specular"));
        rend10.material.SetColor("_Color", Color.magenta);
        hinderniss2.transform.localScale = new Vector3(0.4f, 0.5f, 3);
        hinderniss2.transform.Translate(133.49f, 9.1f, 76.19f);

        /*GameObject end = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rend11 = end.GetComponent<Renderer>();
        rend11.material = new Material(Shader.Find("Specular"));
        rend11.material.SetColor("_Color", Color.red);
        end.transform.localScale = new Vector3(3, 0.5f, 3);
        end.transform.Translate(197.635f, 8.56f, 81.76f);*/

        }
    }
