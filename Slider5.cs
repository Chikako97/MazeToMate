﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider5 : MonoBehaviour {

    bool bewegung;
    float zeitGesamt;
    Vector3 startPunkt;
    Vector3 streckeGesamt;
    float bewegungZeitStart;

    void Start()
    {
        bewegung = false;
        zeitGesamt = 2.5f;
        startPunkt = new Vector3(216.5f, 14.57f, 79);
        Vector3 zielPunkt = new Vector3(257, 14.57f, 77.3f);
        streckeGesamt = zielPunkt - startPunkt;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F5) && !bewegung)
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
