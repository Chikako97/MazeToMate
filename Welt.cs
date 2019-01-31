using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welt : MonoBehaviour
{


    //public GameObject boden;
    public GameObject start;
    public GameObject base1;
    public GameObject end;
    public GameObject slider;

    void Start()
    {
        /*boden = GameObject.CreatePrimitive(PrimitiveType.Plane);
        boden.transform.localScale += new Vector3(10, 0, 10);
        Instantiate(boden);*/

        start = GameObject.CreatePrimitive(PrimitiveType.Cube);
        start.transform.localScale += new Vector3(2, 0, 2);
        start.transform.Translate(0, 0, 0);
        Instantiate(start);

        base1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        base1.transform.localScale += new Vector3(2, 0, 2);
        base1.transform.Translate(15, 0, 0);
        Instantiate(base1);

        end = GameObject.CreatePrimitive(PrimitiveType.Cube);
        end.transform.localScale += new Vector3(3, 0.025f, 3);
        end.transform.Translate(-50, 0, 0);
        Instantiate(end);

        slider = GameObject.CreatePrimitive(PrimitiveType.Cube);
        slider.transform.localScale += new Vector3(3, 0.025f, 3);
        slider.transform.Translate(48.5f, 0, 0);
        Instantiate(slider);



    }

    // Update is called once per frame
    void Update()
    {

    }
}
