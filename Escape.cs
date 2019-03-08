using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Spiel soll mit Escape-Taste beendet werden
            Debug.Log("Spiel wird beendet");
            Application.Quit();
        }
    }
}
