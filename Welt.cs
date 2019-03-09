using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welt : MonoBehaviour
{

    public GameObject raumPrefab;
    [SerializeField] Rigidbody rb;

    void Start()
    {
        

        //Erzeugen der einzelnen Räume anhand des zuvor erstellten Prefab "Raum"
        GameObject[,] raum = new GameObject[4, 4];

        for (int a = 0; a < 4; a++)
        {
            for (int b = 0; b < 4; b++)
            {
                raum[a, b] = (GameObject)Instantiate(raumPrefab, new Vector3(a * 10 + 5, 0, b * 10 + 5), Quaternion.identity);
            }
        }

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
        bool Links = wandLinks;
        bool Hinten = wandHinten;
        bool Rechts = wandRechts;
        bool Vorn = wandVorne;

        switch (Links)
        {
            case true:
                raum.transform.Find("WandLinksOffen").gameObject.SetActive(false);
                break;
            case false:
                raum.transform.Find("WandLinks").gameObject.SetActive(false);
                break;
            default:
                Debug.Log("Wand ist aktiv");
                break;
        }

        switch (Hinten)
        {
            case true:
                raum.transform.Find("WandHintenTor").gameObject.SetActive(false);
                break;
            case false:
                raum.transform.Find("WandHinten").gameObject.SetActive(false);
                break;
            default:
                Debug.Log("Wand ist aktiv");
                break;
        }

        switch (Rechts)
        {
            case true:
                raum.transform.Find("WandRechtsTor").gameObject.SetActive(false);
                break;
            case false:
                raum.transform.Find("WandRechts").gameObject.SetActive(false);
                break;
            default:
                Debug.Log("Wand ist aktiv");
                break;
        }

        switch (Vorn)
        {
            case true:
                raum.transform.Find("WandVorneOffen").gameObject.SetActive(false);
                break;
            case false:
                raum.transform.Find("WandVorne").gameObject.SetActive(false);
                break;
            default:
                Debug.Log("Wand ist aktiv");
                break;
        }
    }
}
