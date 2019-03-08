using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    GameObject boden;
    GameObject plusx;
    GameObject minusx;
    GameObject deckel;
    GameObject plusz;
    GameObject minusz;

    GameObject a;
    GameObject b;
    GameObject c;
    GameObject d;
    GameObject e;

    GameObject cubelight;

    GameObject platzhalterSchlüssel;

    // Use this for initialization
    void Start()
    {
        //Seiten des Würfels
        boden = GameObject.CreatePrimitive(PrimitiveType.Cube);
        boden.name = "Boden";
        boden.transform.localScale = new Vector3(10, (float)0.5, 10);
        boden.transform.Translate(20.5f, 3, 71.87f);

        GameObject plusx = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plusx.name = "rechteWand";
        plusx.transform.localScale = new Vector3(10, (float)0.5, 10);
        plusx.transform.Translate(25.5f, 8, 71.87f);
        plusx.transform.Rotate(0, 0, 90);

        GameObject minusx = GameObject.CreatePrimitive(PrimitiveType.Cube);
        minusx.name = "linkeWand";
        minusx.transform.localScale = new Vector3(10, (float)0.5, 10);
        minusx.transform.Translate(15.5f, 8, 71.87f);
        minusx.transform.Rotate(0, 0, 90);

        GameObject deckel = GameObject.CreatePrimitive(PrimitiveType.Cube);
        deckel.name = "Deckel";
        deckel.transform.localScale = new Vector3(10, (float)0.5, 10);
        deckel.transform.Translate(20.5f, 13, 71.87f);

        GameObject plusz = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plusz.name = "hintereWand";
        plusz.transform.localScale = new Vector3(10, (float)0.5, 10);
        plusz.transform.Translate(20.5f, 8, 76.87f);
        plusz.transform.Rotate(90, 0, 0);

        GameObject minusz = GameObject.CreatePrimitive(PrimitiveType.Cube);
        minusz.name = "vordereWand";
        minusz.transform.localScale = new Vector3(10, (float)0.5, 10);
        minusz.transform.Translate(20.5f, 8, 66.87f);
        minusz.transform.Rotate(90, 0, 0);

        //Parenting Würfelseiten
        boden.transform.SetParent(GameObject.Find("Boden").transform);
        plusx.transform.SetParent(GameObject.Find("Boden").transform);
        minusx.transform.SetParent(GameObject.Find("Boden").transform);
        deckel.transform.SetParent(GameObject.Find("Boden").transform);
        plusz.transform.SetParent(GameObject.Find("Boden").transform);
        minusz.transform.SetParent(GameObject.Find("Boden").transform);

        //Säulen im Würfel
        GameObject a = GameObject.CreatePrimitive(PrimitiveType.Cube);
        a.name = "a";
        a.transform.localScale = new Vector3(2, 1, 10);
        a.transform.Translate(20.5f, 8, 71.87f);

        GameObject b = GameObject.CreatePrimitive(PrimitiveType.Cube);
        b.name = "b";
        b.transform.localScale = new Vector3(2, 1, 10);
        b.transform.Translate(20.5f, 11, 71.87f);

        GameObject c = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c.name = "c";
        c.transform.localScale = new Vector3(2, 1, 10);
        c.transform.Translate(20.5f, 5, 71.87f);

        GameObject d = GameObject.CreatePrimitive(PrimitiveType.Cube);
        d.name = "c";
        d.transform.localScale = new Vector3(2, 1, 10);
        d.transform.Translate(20.5f, 9.5f, 69.87f);
        d.transform.Rotate(0, 90, 0);

        GameObject e = GameObject.CreatePrimitive(PrimitiveType.Cube);
        e.name = "c";
        e.transform.localScale = new Vector3(2, 1, 10);
        e.transform.Translate(20.5f, 6.5f, 73.87f);
        e.transform.Rotate(0, 90, 0);

        //Parenting Säulen an Würfel
        a.transform.SetParent(GameObject.Find("Boden").transform);
        b.transform.SetParent(GameObject.Find("Boden").transform);
        c.transform.SetParent(GameObject.Find("Boden").transform);
        d.transform.SetParent(GameObject.Find("Boden").transform);
        e.transform.SetParent(GameObject.Find("Boden").transform);

        //Schlüssel (Parenting)
        platzhalterSchlüssel.transform.Translate(20.5f, 10, 71.8f);
        platzhalterSchlüssel.transform.SetParent(GameObject.Find("Boden").transform)

        //Licht
        GameObject cubelight = new GameObject("The Light");
        Light lightCom = cubelight.AddComponent<Light>();
        lightCom.color = Color.white;
        cubelight.transform.Translate(20.5f, 13, 71.87f);

        //Tag für Eisfläche
        boden.tag = "Eis";
        plusx.tag = "Eis";
        minusx.tag = "Eis";
        plusz.tag = "Eis";
        minusz.tag = "Eis";
        deckel.tag = "Eis";
        a.tag = "Eis";
        b.tag = "Eis";
        c.tag = "Eis";
        d.tag = "Eis";
        e.tag = "Eis";

    }

    // Update is called once per frame
    void Update()
    {
        boden.transform.Rotate(new Vector3(Time.deltaTime * 20, 0, 0));

    }
}