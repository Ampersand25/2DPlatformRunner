using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour {

    public void OpenGitHubPage()
    {
        Application.OpenURL("https://github.com/Ampersand25");
    }

    public void OpenItchioPage()
    {
        Application.OpenURL("https://ampersand25.itch.io/");
    }

    public void OpenLinkedInPage()
    {
        Application.OpenURL("https://www.linkedin.com/in/cristian-stanciu-b8248b164/");
    }
}
