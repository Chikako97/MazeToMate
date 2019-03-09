using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider9 : MonoBehaviour {

    bool bewegung;
    float zeitGesamt;
    Vector3 startPunkt;
    Vector3 streckeGesamt;
    float bewegungZeitStart;

    void Start()
    {
        bewegung = false;
        zeitGesamt = 2.5f;
        startPunkt = new Vector3(172.135f, 8.56f, 107.31f);
        Vector3 zielPunkt = new Vector3(194.63f, 8.56f, 81.8f);
        streckeGesamt = zielPunkt - startPunkt;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.I) && !bewegung)
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
