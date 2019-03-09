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
        startPunkt = new Vector3(64.17f, 8.56f, 84.89f);
        Vector3 zielPunkt = new Vector3(64.17f, 8.56f, 97.99f);
        streckeGesamt = zielPunkt - startPunkt;
	}
	
	void Update () {
		
        if(Input.GetKeyDown (KeyCode.B) && !bewegung)
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
