using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider3 : MonoBehaviour {

    bool bewegung;
    float zeitGesamt;
    Vector3 startPunkt;
    Vector3 streckeGesamt;
    float bewegungZeitStart;

    void Start()
    {
        bewegung = false;
        zeitGesamt = 2.5f;
        startPunkt = new Vector3(18.01f, 0, 19.2f);
        Vector3 zielPunkt = new Vector3(40, 0, 19.2f);
        streckeGesamt = zielPunkt - startPunkt;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C) && !bewegung)
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
