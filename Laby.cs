using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Laby : MonoBehaviour {


    [System.Serializable] 
    public class Zelle
    {
        public GameObject oben;
        public GameObject links;
        public GameObject rechts;
        public GameObject unten;
        public bool abgecheckt;

      
    }

    public GameObject Wand;
    public float WandLaenge = 1.0f;
    public int xSeite = 10;
    public int ySeite = 10;

    private GameObject Wandspeicher;
    private Vector3 ausgangspunkt;
    private Zelle[] Zellen;
    public int aktuelleZelle = 0;
    private int alleZellen;
    private int abgecheckteZellen = 0;

    private bool bauePfad = false;
    private int aktuellerNachbar;
    private List<int> letzteZellen;
    private int sichern = 0;
    private int WandWegmachen = 0;

    // Use this for initialization
    void Start () {

        BaueWaende();

	}

    void BaueWaende()
    {

        Wandspeicher = new GameObject();
        Wandspeicher.name = "Labyrinth";

        ausgangspunkt = new Vector3((-xSeite / 2) + WandLaenge / 2, 0, (-ySeite / 2) + WandLaenge / 2); // Punkt von dem aus ich die Wände bauen lasse
        Vector3 meinPunkt = ausgangspunkt; // 
        GameObject platzhalter;

        // Für die X Seite
        for (int a = 0; a < ySeite; a++)
        {
            for (int b = 0; b <= xSeite; b++)
            {
                meinPunkt = new Vector3(ausgangspunkt.x + (b * WandLaenge) - WandLaenge / 2, 0, ausgangspunkt.z + (a * WandLaenge) - WandLaenge / 2);
                platzhalter = Instantiate(Wand, meinPunkt, Quaternion.identity); // Instantiate --> spawnt Objekte, die Zeile spawnt Wände auf der X Seite
                platzhalter.transform.parent = Wandspeicher.transform;
            }
        }

        // Für die Y Seite
        for (int a = 0; a <= ySeite; a++)
        {
            for (int b = 0; b < xSeite; b++)
            {
                meinPunkt = new Vector3(ausgangspunkt.x + (b * WandLaenge), 0, ausgangspunkt.z + (a * WandLaenge) - WandLaenge);
                platzhalter = Instantiate(Wand, meinPunkt, Quaternion.Euler(0.0f, 90.0f, 0.0f)) as GameObject; // Instantiate --> spawnt Objekte, die ganze zeile spawnt Wände auf der Y Seite
                platzhalter.transform.parent = Wandspeicher.transform;
            }
        }


        // Die Wände werden von unten nach oben von links nach rechts gespawnt. Erst die Y Seite, dann die X Seite

        ErzeugeZellen();
    }

    //Funktion um die erstellten Wände zu Zellen zusammenzuführen
    void ErzeugeZellen()
    {
        alleZellen = xSeite * ySeite;
        letzteZellen = new List<int>();
        letzteZellen.Clear();
        //Ermitteln wie viele Unterpunkte es gibt
        int children = Wandspeicher.transform.childCount;
        GameObject[] gesamteWaende = new GameObject[children];

        Zellen = new Zelle[xSeite * ySeite];
        
        int Wandablauf = 0;
        int Kindablauf = 0;
        int LaufzeitCount = 0;

        //Die ganzen Wände in einer Variable speichern
        for (int a = 0; a < children; a++)
        {
            gesamteWaende[a] = Wandspeicher.transform.GetChild(a).gameObject;
        }

        //Wände den Zellen zuweisen
        for(int Zellzuweisung = 0; Zellzuweisung < Zellen.Length; Zellzuweisung++)
        {
            Zellen[Zellzuweisung] = new Zelle();

            //Die erste Wand der Y Seite ermitteln - passiert unmittelbar nach starten des Programms, da die erste Wand eine Wand der Y Seite ganz unten links ist
            Zellen[Zellzuweisung].links = gesamteWaende[Wandablauf];

            //Die erste Wand der X Seite ermitteln - nach dem alle Wände der Y Seite von unten nach oben, Reihe für Reihe in dem Klonprozess gespawnt werden, wird auch die erste Wand der X Seite unten links gespawnt
            Zellen[Zellzuweisung].unten = gesamteWaende[Kindablauf + (xSeite+1) * ySeite];

            if(LaufzeitCount == xSeite)
            {
                Wandablauf++;
                Wandablauf++;
                LaufzeitCount = 0;
            }
            else
            {
                Wandablauf++;
            }

            LaufzeitCount++;
            Kindablauf++;
            Zellen[Zellzuweisung].rechts = gesamteWaende[Wandablauf];
            Zellen[Zellzuweisung].oben = gesamteWaende[(Kindablauf + (xSeite + 1) * ySeite) + xSeite - 1];

        }

        ErstelleLabyrinth();
    }

    void ErstelleLabyrinth()
    {
    
       
        if (abgecheckteZellen < alleZellen)
        {
            if (bauePfad)
            {
                ErmittleZellenNachbarn();

                if (Zellen[aktuellerNachbar].abgecheckt == false && Zellen[aktuelleZelle].abgecheckt == true)
                {
                    EntferneWand();
                    Zellen[aktuellerNachbar].abgecheckt = true;
                    abgecheckteZellen++;
                    letzteZellen.Add(aktuelleZelle);
                    aktuelleZelle = aktuellerNachbar;

                    if (letzteZellen.Count > 0)
                    {
                        sichern = letzteZellen.Count - 1;
                    }
                }
            }
            else
            {
                aktuelleZelle = Random.Range(0, alleZellen);
                Zellen[aktuelleZelle].abgecheckt = true;
                abgecheckteZellen++;
                bauePfad = true;
            }
            
        }
        Invoke("Erstelle Labyrinth", 0.0f);
        // Debug.Log("Ist Fertig");
    }

    void EntferneWand()
    {
        switch (WandWegmachen)
        {
            case 1: Destroy(Zellen[aktuelleZelle].oben); break;
            case 2: Destroy(Zellen[aktuelleZelle].rechts); break;
            case 3: Destroy(Zellen[aktuelleZelle].links); break;
            case 4: Destroy(Zellen[aktuelleZelle].unten); break;
        }
    }

    void ErmittleZellenNachbarn()
    {
        int laenge = 0;
        int[] Nachbarn = new int[4]; //4 --> Weil eine Zelle nur 4 Nachbarn haben kann. oben, unten, links, rechts
        int[] angrenzendeWand = new int[4];
        int pruefen = ((aktuelleZelle + 1) / xSeite);

        pruefen -= 1;
        pruefen *= xSeite; //Multipliziert den rechten Wert mit dem linken
        pruefen += xSeite;

        //Linker Nachbar
         if(aktuelleZelle + 1 < alleZellen && (aktuelleZelle + 1) != pruefen)
        {
            if(Zellen[aktuelleZelle + 1].abgecheckt == false)
            {
                Nachbarn[laenge] = aktuelleZelle + 1;
                angrenzendeWand[laenge] = 3;
                laenge++;
            }
        }

        //Rechter Nachbar
        if (aktuelleZelle - 1 >= 0 && aktuelleZelle != pruefen)
        {
            if (Zellen[aktuelleZelle - 1].abgecheckt == false)
            {
                Nachbarn[laenge] = aktuelleZelle - 1;
                angrenzendeWand[laenge] = 2;
                laenge++;
            }
        }

        //Oberer Nachbar
        if (aktuelleZelle + xSeite < alleZellen)
        {
            if (Zellen[aktuelleZelle + xSeite].abgecheckt == false)
            {
                Nachbarn[laenge] = aktuelleZelle + xSeite;
                angrenzendeWand[laenge] = 1;
                laenge++;
            }
        }

        //Unterer Nachbar
        if (aktuelleZelle - xSeite >= 0)
        {
            if (Zellen[aktuelleZelle - xSeite].abgecheckt == false)
            {
                Nachbarn[laenge] = aktuelleZelle - xSeite;
                angrenzendeWand[laenge] = 4;
                laenge++;
            }
        }
        
        
        //Nachbarn anzeigen lassen um zu prüfen ob es funktioniert
        for(int i = 0; i < laenge; i++)
        {
            Debug.Log(Nachbarn[i]);
        }
        

        //Abfrage wenn kein Nachbar gefunden wurde
        if(laenge != 0)
        {
            int platzhalter2 = Random.Range(0, laenge);
            aktuellerNachbar = Nachbarn[platzhalter2];
            WandWegmachen = angrenzendeWand[platzhalter2];
            
        }
        else
        {
            if(sichern < 0)
            {
                aktuelleZelle = letzteZellen[sichern];
                sichern--;
            }
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
