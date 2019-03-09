using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider7 : MonoBehaviour {

    bool bewegung;
    float zeitGesamt;
    Vector3 startPunkt;
    Vector3 streckeGesamt;
    float bewegungZeitStart;

    void Start()
    {
        bewegung = false;
        zeitGesamt = 2.5f;
        startPunkt = new Vector3(119.155f, 8.56f, 76.19f);
        Vector3 zielPunkt = new Vector3(146.15f, 8.56f, 76.19f);
        streckeGesamt = zielPunkt - startPunkt;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G) && !bewegung)
        {
            bewegung = true;
            bewegungZeitStart = Time.time;
        }

        if (bewegung)
        {
            float zeitAnteil = (Time.time - bewegungZeitStart) / zeitGesamt;
            Vector3 streckeAnteil = zeitAnteil * streckeGesamt;
            transform.position = startPunkt + streckeAnteil;
            if (zeitAnteil >= 1) bewegung = false;
        }
    }
}
