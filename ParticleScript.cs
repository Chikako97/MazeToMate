using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript: MonoBehaviour {

    private ParticleSystem ps;
    private ParticleSystem ps1;

    // Use this for initialization
    void Start () {

        ps = GetComponent<ParticleSystem>();
        ps1 = GetComponent<ParticleSystem>();

    }
	
	// Update is called once per frame
	void Update () {
		
        if(!ps.isPlaying)
        {
            Destroy(gameObject);
        }

        if (!ps1.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
