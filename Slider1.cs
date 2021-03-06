﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider1 : MonoBehaviour {

    bool bewegung;
    float zeitGesamt;
    Vector3 startPunkt;
    Vector3 streckeGesamt;
    float bewegungZeitStart;

	void Start () 
    {
        bewegung = false;
        zeitGesamt = 1;
      	startPunkt = new Vector3(71.40f, 8.5f, 21);
        Vector3 zielPunkt = new Vector3(99.6f, 8.5f, 21.6f);
        streckeGesamt = zielPunkt - startPunkt;
	}
	
	void Update () {
		
        if(Input.GetKeyDown (KeyCode.F1) && !bewegung)
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
