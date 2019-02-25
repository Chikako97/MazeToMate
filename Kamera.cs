using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject spieler;
    float abstandXZ = 1;
    float hoeheY = 0.2f;

    void Update()
    {
        Quaternion spielerRotationY = new Quaternion();
        spielerRotationY.eulerAngles = new Vector3(0, spieler.transform.eulerAngles.y, 0);
        Vector3 abstandHinterSpieler = spielerRotationY * new Vector3(0, 0, abstandXZ);
        transform.position = spieler.transform.position - abstandHinterSpieler;
        transform.position = new Vector3(transform.position.x,
        transform.position.y + hoeheY, transform.position.z);
        transform.LookAt(spieler.transform);
    }
}

