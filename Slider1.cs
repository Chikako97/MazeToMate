using System.Collections;
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
      	startPunkt = new Vector3(52.14f, 8.56f, 81.79f);
        Vector3 zielPunkt = new Vector3(61.13f, 8.56f, 81.88f);
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
