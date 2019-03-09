using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NimmSchlussel : MonoBehaviour {

    public Component torschlussel;
    public GameObject Schlussel;
    public GameObject Besitz;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay () {

        bool caseSwitch = Input.GetKey(KeyCode.P);

        switch (caseSwitch)
        {
            case true:
                torschlussel.GetComponent<BoxCollider>().enabled = true;
                break;
            case false:
                Schlussel.SetActive(false);
                Besitz.SetActive(true);
                break;
            default:
                Debug.Log("Schluessel aufgenommen");
                break;
        }
    }
}
