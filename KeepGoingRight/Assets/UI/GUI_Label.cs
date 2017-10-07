using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GUI_Label : MonoBehaviour
{
    public bool debugMode = false;
	private void OnGUI()
    {
        if (debugMode || Application.isPlaying)
        {
            GUI.color = Color.cyan;
            GUI.Label(new Rect(200, 15, 75, 75), "Let the Game Begin");
        }
    }
}
