using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject spieler;
    float abstand = 1;
    float hoehe = 0.2f;

    void Update()
    {
        Quaternion spielerRotation = new Quaternion();
        spielerRotation.eulerAngles = new Vector3(0, spieler.transform.eulerAngles.y, 0);
        Vector3 abstandZuSpieler = spielerRotation * new Vector3(0, 0, abstand);
        transform.position = spieler.transform.position - abstandZuSpieler;
        transform.position = new Vector3(transform.position.x, transform.position.y + hoehe, transform.position.z);
        transform.LookAt(spieler.transform);
    }
    
    void Exit(Collider other) {
        if (other.tag == "Tile") {
            RaycastHit hit;
            
            Ray down = new Ray(transform.position, -Vector3.up);
            
            if (!Physics.Raycast(down, out hit)) {
                dead = true;
                transform.GetChild(0).transform.parent = null;
            }
        }
    }
}

