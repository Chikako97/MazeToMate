using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{


    // Use this for initialization
    void Start () {

        GameObject boden = GameObject.CreatePrimitive(PrimitiveType.Cube);
        boden.transform.localScale = new Vector3(10, (float)0.5, 10);
        boden.transform.Translate(0, -5, 0);

        GameObject plusx = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plusx.transform.localScale = new Vector3(10, (float)0.5, 10);
        plusx.transform.Translate(5, 0, 0); 
        plusx.transform.Rotate(0, 0, 90);

        GameObject minusx = GameObject.CreatePrimitive(PrimitiveType.Cube);
        minusx.transform.localScale = new Vector3(10, (float)0.5, 10);
        minusx.transform.Translate(-5, 0, 0);
        minusx.transform.Rotate(0, 0, 90);

        GameObject deckel = GameObject.CreatePrimitive(PrimitiveType.Cube);
        deckel.transform.localScale = new Vector3(10, (float)0.5, 10);
        deckel.transform.Translate(0, 5, 0);

        GameObject plusz = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plusz.transform.localScale = new Vector3(10, (float)0.5, 10);
        plusz.transform.Translate(0, 0, 5);
        plusz.transform.Rotate(90, 0, 0);

        GameObject minusz = GameObject.CreatePrimitive(PrimitiveType.Cube);
        minusz.transform.localScale = new Vector3(10, (float)0.5, 10);
        minusz.transform.Translate(0, 0, -5);
        minusz.transform.Rotate(90, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
        boden.transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
        plusx.transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
        minusx.transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
        deckel.transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
        plusz.transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
        minusz.transform.Rotate(new Vector3(Time.deltaTime * 50, 0, 0));
    }
}
