using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaefig : MonoBehaviour
{

    Shader shader;
    Texture texture;
    Color color;
    public Material stein;

    // Use this for initialization
    void Start()
    {
        GameObject K1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend = K1.GetComponent<MeshRenderer>();
        rend.material = new Material(Shader.Find("Specular"));
        rend.material = stein;
        K1.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        K1.transform.Translate(34.423f, 0.236f, 36.756f);

        GameObject K12 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend8 = K12.GetComponent<MeshRenderer>();
        rend8.material = new Material(Shader.Find("Specular"));
        rend8.material =stein;
        K12.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        K12.transform.Translate(34.623f, 0.236f, 36.756f);

        GameObject K13 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend9 = K13.GetComponent<MeshRenderer>();
        rend9.material = new Material(Shader.Find("Specular"));
        rend9.material = stein;
        K13.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        K13.transform.Translate(34.833f, 0.236f, 36.756f);

        GameObject K14 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend44 = K14.GetComponent<MeshRenderer>();
        rend44.material = new Material(Shader.Find("Specular"));
        rend44.material = stein;
        K14.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        K14.transform.Translate(35.083f, 0.236f, 36.756f);

        GameObject K15 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend55 = K15.GetComponent<MeshRenderer>();
        rend55.material = new Material(Shader.Find("Specular"));
        rend55.material = stein;
        K15.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        K15.transform.Translate(35.323f, 0.236f, 36.756f);

        GameObject K131 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend91 = K131.GetComponent<MeshRenderer>();
        rend91.material = new Material(Shader.Find("Specular"));
        rend91.material = stein;
        K131.transform.localScale = new Vector3(1f, 0.1f, 0.2f);
        K131.transform.Translate(34.879f, 0.405f, 36.773f);

        GameObject K130 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend90= K130.GetComponent<MeshRenderer>();
        rend90.material = new Material(Shader.Find("Specular"));
        rend90.material = stein;
        K130.transform.localScale = new Vector3(1f, 0.1f, 0.2f);
        K130.transform.Translate(34.879f, 0.405f, 37.438f);

        GameObject K2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend2 = K2.GetComponent<MeshRenderer>();
        rend2.material = new Material(Shader.Find("Specular"));
        rend2.material = stein;
        K2.transform.localScale = new Vector3(1, 0.3f, 0.1f);
        K2.transform.Translate(34.88f, 0.236f, 37.497f);

        GameObject K3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend3 = K3.GetComponent<MeshRenderer>();
        rend3.material = new Material(Shader.Find("Specular"));
        rend3.material = stein;
        K3.transform.localScale = new Vector3(0.1f, 0.1f, 0.3f);
        K3.transform.Translate(34.431f, 0.405f, 36.773f);

        GameObject K31 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend31 = K31.GetComponent<MeshRenderer>();
        rend31.material = new Material(Shader.Find("Specular"));
        rend31.material = stein;
        K31.transform.localScale = new Vector3(0.1f, 0.1f, 0.3f);
        K31.transform.Translate(34.431f, 0.405f, 37.464f);

        GameObject K4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend4 = K4.GetComponent<MeshRenderer>();
        rend4.material = new Material(Shader.Find("Specular"));
        rend4.material = stein;
        K4.transform.localScale = new Vector3(0.1f, 0.1f, 0.3f);
        K4.transform.Translate(35.316f, 0.405f, 37.464f);

        GameObject K41 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend41 = K41.GetComponent<MeshRenderer>();
        rend41.material = new Material(Shader.Find("Specular"));
        rend41.material = stein;
        K41.transform.localScale = new Vector3(0.1f, 0.1f, 0.3f);
        K41.transform.Translate(35.316f, 0.405f, 36.773f);

        GameObject K5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend5 = K5.GetComponent<MeshRenderer>();
        rend5.material = new Material(Shader.Find("Specular"));
        rend5.material = stein;
        K5.transform.localScale = new Vector3(1, 0.25f, 0.1f);
        K5.transform.Translate(34.88f, 0.549f, 37.365f);

        GameObject K6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend6 = K6.GetComponent <MeshRenderer>();
        rend6.material = new Material(Shader.Find("Specular"));
        rend6.material = stein;
        K6.transform.localScale = new Vector3(1, 0.25f, 0.1f);
        K6.transform.Translate(34.88f, 0.549f, 36.864f);

        GameObject K7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshRenderer rend7 = K7.GetComponent<MeshRenderer>();
        rend7.material = new Material(Shader.Find("Specular"));
        rend7.material = stein;
        K7.transform.localScale = new Vector3(0.9f, 0.1f, 0.6f);
        K7.transform.Translate(34.88f, 0.697f, 37.12f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}