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

    //GameObject parent;
   

    // Use this for initialization
    void Start () {

        boden = GameObject.CreatePrimitive(PrimitiveType.Cube);
        boden.name = "Boden";
        boden.transform.localScale = new Vector3(10, (float)0.5, 10);
        boden.transform.Translate(0, -5, 0);

        GameObject plusx = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plusx.name = "rechteWand";
        plusx.transform.localScale = new Vector3(10, (float)0.5, 10);
        plusx.transform.Translate(5, 0, 0); 
        plusx.transform.Rotate(0, 0, 90);

        GameObject minusx = GameObject.CreatePrimitive(PrimitiveType.Cube);
        minusx.name = "linkeWand";
        minusx.transform.localScale = new Vector3(10, (float)0.5, 10);
        minusx.transform.Translate(-5, 0, 0);
        minusx.transform.Rotate(0, 0, 90);

        GameObject deckel = GameObject.CreatePrimitive(PrimitiveType.Cube);
        deckel.name = "Deckel";
        deckel.transform.localScale = new Vector3(10, (float)0.5, 10);
        deckel.transform.Translate(0, 5, 0);

        GameObject plusz = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plusz.name = "hintereWand";
        plusz.transform.localScale = new Vector3(10, (float)0.5, 10);
        plusz.transform.Translate(0, 0, 5);
        plusz.transform.Rotate(90, 0, 0);

        GameObject minusz = GameObject.CreatePrimitive(PrimitiveType.Cube);
        minusz.name = "vordereWand";
        minusz.transform.localScale = new Vector3(10, (float)0.5, 10);
        minusz.transform.Translate(0, 0, -5);
        minusz.transform.Rotate(90, 0, 0);

        boden.transform.SetParent(GameObject.Find("Boden").transform);
        plusx.transform.SetParent(GameObject.Find("Boden").transform);
        minusx.transform.SetParent(GameObject.Find("Boden").transform);
        deckel.transform.SetParent(GameObject.Find("Boden").transform);
        plusz.transform.SetParent(GameObject.Find("Boden").transform);
        minusz.transform.SetParent(GameObject.Find("Boden").transform);

    }
	
	// Update is called once per frame
	void Update () {
        boden.transform.Rotate(new Vector3(Time.deltaTime * 20, 0, 0));

    }
}
