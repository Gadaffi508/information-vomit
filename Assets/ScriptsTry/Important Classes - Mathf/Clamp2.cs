using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp2 : MonoBehaviour
{
    public int health = 17;
    private int[] healthUp = new int[] { 25, 10, 5, 1 };
    private int[] healthDown = new int[] { -10, -5, -2, -1 };

    // Width and height for the buttons.
    private int xButton = 75;
    private int yButton = 50;

    // Place of the top left button.
    private int xPos1 = 50, yPos1 = 100;
    private int xPos2 = 125, yPos2 = 100;

    void OnGUI()
    {
        GUI.skin.label.fontSize = 20;
        GUI.skin.button.fontSize = 20;

        // Generate and show positive buttons.
        for (int i = 0; i < healthUp.Length; i++)
        {
            if (GUI.Button(new Rect(xPos1, yPos1 + i * yButton, xButton, yButton), healthUp[i].ToString()))
            {
                health += healthUp[i];
            }
        }

        // Generate and show negative buttons.
        for (int i = 0; i < healthDown.Length; i++)
        {
            if (GUI.Button(new Rect(xPos2, yPos2 + i * yButton, xButton, yButton), healthDown[i].ToString()))
            {
                health += healthDown[i];
            }
        }

        // Show health between 1 and 100.
        health = Mathf.Clamp(health, 1, 100);
        GUI.Label(new Rect(xPos1, xPos1, 2 * xButton, yButton), "Health: " + health.ToString("D3"));
    }
}
