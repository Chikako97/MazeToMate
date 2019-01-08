using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welt : MonoBehaviour
{
    public GameObject raumPrefab;

    //Steuerung der Spielfigur
    private Vector3 dir;
    private float speed = 10f;
    private float sprungkraft = 7f;
    private float gravity = 30f;
    private Vector3 moveDir = Vector3.zero; 
    bool weltStehe = false;
    float translateFaktor = 3;
    float rotateFaktor = 100;

    GameObject Durchgang;
    int durchgangStatus = 0;  // Status = 0 besagt, dass Spieler nichts berührt bzw alle Tore geschlossen sind
    public Material schwarzMat;
    public Material rot;

    GameObject truhe;
    int truheIndex;
    int truheStatus = 0;    // Status = 0 besagt, dass Spieler nichts berührt bzw alle Tore geschlossen sind
    public GameObject[] schluessel = new GameObject[12];
    public GameObject[] besitz = new GameObject[12];

    int sperreStatus = 0;   // Status = 0 besagt, dass Spieler nichts berührt bzw alle Tore geschlossen sind
    int sperreIndex;
    public GameObject[] sperre = new GameObject[8];

    void Start()
    {

        dir = Vector3.zero;

        //Erzeugen der einzelnen Räume anhand des zuvor erstellten Prefab "Raum"
        GameObject[,] raum = new GameObject[4, 4];

        for (int x = 0; x < 4; x++)
            for (int z = 0; z < 4; z++)
                raum[x, z] = (GameObject)Instantiate(raumPrefab, new Vector3(x * 10 + 5, 0, z * 10 + 5), Quaternion.identity);

        // Bsp Raum hat eine durchgehende linke wand (true), eine hintere Wand mit einem Tor zur Nachbarkammer (false),
        // eine durchgehende rechte Wand (true), eine vordere Wand mit einer Öffnung für ein Tor zum Nachbarraum (true)
        RaumKonfig(raum[0, 0], true, false, true, true);
        RaumKonfig(raum[0, 1], true, false, false, false);
        RaumKonfig(raum[0, 2], true, false, true, false);
        RaumKonfig(raum[0, 3], true, true, true, false);

        RaumKonfig(raum[1, 0], true, true, false, true);
        RaumKonfig(raum[1, 1], false, false, false, true);
        RaumKonfig(raum[1, 2], true, false, true, false);
        RaumKonfig(raum[1, 3], true, true, false, false);

        RaumKonfig(raum[2, 0], false, false, false, true);
        RaumKonfig(raum[2, 1], false, false, false, false);
        RaumKonfig(raum[2, 2], true, true, false, false);
        RaumKonfig(raum[2, 3], false, true, true, true);

        RaumKonfig(raum[3, 0], false, true, true, true);
        RaumKonfig(raum[3, 1], false, true, true, true);
        RaumKonfig(raum[3, 2], false, false, true, true);
        RaumKonfig(raum[3, 3], true, true, true, false);
    }

    // Räume konfigurieren und die jeweiligen Seiten, die ein Durchgang haben sollen, werden aktiviert/ deaktiviert
    void RaumKonfig(GameObject raum, bool wandLinks, bool wandHinten, bool wandRechts, bool wandVorne)
    {
        if (wandLinks)
        {
            raum.transform.Find("WandLinksOffen").gameObject.SetActive(false);
        }
        else
        {
            raum.transform.Find("WandLinks").gameObject.SetActive(false);
        }
        if (wandHinten)
        {
            raum.transform.Find("WandHintenTor").gameObject.SetActive(false);
        }
        else
        {
            raum.transform.Find("WandHinten").gameObject.SetActive(false);
        }
        if (wandRechts)
        {
            raum.transform.Find("WandRechtsTor").gameObject.SetActive(false);
        }
        else
        {
            raum.transform.Find("WandRechts").gameObject.SetActive(false);
        }
        if (wandVorne)
        {
            raum.transform.Find("WandVorneOffen").gameObject.SetActive(false);
        }
        else
        {
            raum.transform.Find("WandVorne").gameObject.SetActive(false);
        }
    }

    void Update()
    {

        // Status 2 = "Oeffne Tür" wurde aktiviert und es oeffnet sich selbstständig und Spieler entfärbt sich und kann weiter gehen
        if (durchgangStatus == 2)
        {
            Durchgang.transform.position = Durchgang.transform.position + new Vector3(0, Time.deltaTime, 0);
            if (Durchgang.transform.position.y >= 1.5f)
            {
                durchgangStatus = 3;
                weltStehe = false;
                gameObject.GetComponent<Renderer>().material = rot;
                Invoke("TorSchliesst", 2.5f);
            }
        }
        // Tür schließt sich
        else if (durchgangStatus == 4)
        {
            Durchgang.transform.position = Durchgang.transform.position - new Vector3(0, Time.deltaTime, 0);
            if (Durchgang.transform.position.y <= 0.5f)
            {
                durchgangStatus = 0;
            }
        }
        // Status 2 = "Oeffne truhe" wurde aktiviert und es oeffnet sich selbstständig und Spieler entfärbt sich und kann weiter gehen
        if (truheStatus == 2)
        {
            truhe.transform.position = truhe.transform.position + new Vector3(0, Time.deltaTime, 0);
            if (truhe.transform.position.y >= 1.1f)
            {
                //Das Tor ist für 2 Sekunden geoeffnet
                truheStatus = 3;
                Invoke("KisteSchliesst", 2.5f);
                if (besitz[truheIndex].activeInHierarchy)
                {
                    weltStehe = false;
                    gameObject.GetComponent<Renderer>().material = rot;
                }
            }
        }
        // Truhe schließt sich wieder 
        else if (truheStatus == 4)
        {
            truhe.transform.position = truhe.transform.position - new Vector3(0, Time.deltaTime, 0);
            if (truhe.transform.position.y <= 0.5f)
            {
                truheStatus = 0;
            }
        }

        //Steuerung der Spielfigur
        if (!weltStehe)
        {
            transform.Translate(new Vector3(0, 0, translateFaktor * Time.deltaTime * Input.GetAxis("Vertical")));
            transform.Rotate(new Vector3(0, rotateFaktor * Time.deltaTime * Input.GetAxis("Horizontal"), 0));

            CharacterController controller = gameObject.GetComponent<CharacterController>();

            if (controller.isGrounded)
            {
                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDir = transform.TransformDirection(moveDir);
                moveDir *= speed;

                // Figur zum springen bringen
                if (Input.GetButtonUp("Jump"))
                {
                    moveDir.y = sprungkraft;
                }
            }
            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);
        } 
    }

    // Reaktion bei Beruehrung wird ausgelöst = Spieler wird betäubt und verfärtb
    void OnTriggerEnter(Collider other, Collider coll)
    {
        if (coll.gameObject.tag == "Tor")
        {
            Durchgang = coll.gameObject;
            durchgangStatus = 1;
            weltStehe = true;
            gameObject.GetComponent<Renderer>().material = schwarzMat;
        }
        else if (coll.gameObject.tag == "Truhe")
        {
            truhe = coll.gameObject;
            truheIndex = System.Convert.ToInt32(truhe.name.Substring(5, 1));
            truheStatus = 1;
            weltStehe = true;
            gameObject.GetComponent<Renderer>().material = schwarzMat;
        }
        else if (coll.gameObject.tag == "Sperre")
        {
            sperreIndex = System.Convert.ToInt32(coll.gameObject.name.Substring(6, 1));
            sperreStatus = 1;
            weltStehe = true;
            gameObject.GetComponent<Renderer>().material = schwarzMat;
        }
    }

    void TorSchliesst()
    {
        durchgangStatus = 4;
    }

    public void OeffneTor()
    {
        if (durchgangStatus == 1)
        {                               //Spieler wird betäubt und wechselt farbe
            durchgangStatus = 2;
        }
    }

    void TruheSchliesst()
    {
        truheStatus = 4;
    }

    public void OeffneTruhe()
    {
        if (truheStatus == 1)
        {
            truheStatus = 2;
        }
    }

    public void NimmSchluesselAuf()
    {
        if (truheStatus == 3)
        {
            besitz[truheIndex].SetActive(true);
            schluessel[truheIndex].SetActive(false);
            weltStehe = false;
            gameObject.GetComponent<Renderer>().material = rot;
        }
    }

    public void SchliesseSperreAuf()
    {
        if (sperreStatus == 1 && besitz[sperreIndex].activeInHierarchy) 
            sperre[sperreIndex].SetActive(false);
        sperreStatus = 0;
        weltStehe = false;
        gameObject.GetComponent<Renderer>().material = rot;
    }
}
