using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallendePlattform : MonoBehaviour {

    bool faellt = false;
    float fallGeschw = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (collider.gameObject.name == "Spieler")
        {
            faellt = true;
            Destroy(gameObject, 10);
        }
    }

    private void Update()
    {
        if (faellt)
        {
            fallGeschw += Time.deltaTime;

            transform.position = new Vector3(transform.position.x, transform.position.y - fallGeschw, transform.position.z);
        }
    }
}
