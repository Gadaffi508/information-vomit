using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public void ButtonTestDebug(Button button)
    {
        Debug.Log(button.name);
    }
    public void OpenGoogle()
    {
        Application.OpenURL("www.google.com");
    }
    public void OpenInstagram()
    {
        Application.OpenURL("www.instagram.com/explore/tags/%C4%B1nstagram");
    }
}
