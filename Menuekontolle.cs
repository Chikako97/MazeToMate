using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuekontolle : MonoBehaviour {

    public GameObject pauseMenue;
    public bool istPause;

     
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (istPause)
            {
                WeiterSpielen();
            }
            else
            {
                istPause = true;
                pauseMenue.SetActive(true);
                Time.timeScale = 0f; //Zeit anhalten
            }
        }
    } 

    public void WeiterSpielen()
    {
        istPause = false;
        pauseMenue.SetActive(false);
        Time.timeScale = 1f;
    }
}
