using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class GetText : MonoBehaviour
{

    [Space(10)]
    [Header("Druecken fuer Vorschau")]
    public bool On;


    [Space(10)]
    [Header("Angezeigter Text bei OnTrigger")]
    public string Text = "Text eingeben";

    [Tooltip("Das ist die Fenstergroesse. Es ist mittig voreingestellt. Aendere X oder Y um das Fenster zu verschieben.")]
    public Rect BoxSize = new Rect(0, 0, 200, 100);

    //Verschoenerung
    [Space(10)]
    [Tooltip("To edit the look of the text Go to Assets > Create > GUIskin. Add the new Guiskin to the Custom Skin proptery. If you select the GUIskin in your project tab you can now adjust the font, colour, size etc of the text")]
    public GUISkin Skin;



    // Wenn das Script einem Objekt mit einem Collider zugewiesen ist zeige den Text.
    void OnTriggerEnter()
    {
        On = true;
    }


    void OnTriggerExit()
    {
        On = false;
    }

    void OnGUI()
    {

        if (Skin != null)
        {
            GUI.skin = Skin;
        }

        if (On == true)
        {
            // Erstelle Gruppe mittig
            GUI.BeginGroup(new Rect((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2, BoxSize.width, BoxSize.height));
            // Alle Rechtecke werden an die Gruppe angepasst. (0,0) ist die Ecke der Gruppe obenlinks.

            GUI.Label(BoxSize, Text);

            // Beenden der Gruppe! 
            GUI.EndGroup();

        }


    }

}