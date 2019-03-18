using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider2 : MonoBehaviour {

    bool bewegung;
    float zeitGesamt;
    Vector3 startPunkt;
    Vector3 streckeGesamt;
    float bewegungZeitStart;

	void Start () 
    {
        bewegung = false;
        zeitGesamt = 1;
         startPunkt = new Vector3(107, 8.5f, 28.5f);
        Vector3 zielPunkt = new Vector3(108, 8.5f, 71.0f);
        streckeGesamt = zielPunkt - startPunkt;
	}
	
	void Update () {
		
        if(Input.GetKeyDown (KeyCode.F2) && !bewegung)
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
