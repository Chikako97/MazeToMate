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

      
        //Steuerung der Spielfigur
        if (!weltStehe)
        {
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

}
