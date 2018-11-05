using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public void QuitGame()
    {
        PlayerControls.deathCount = PlayerControls.deathCount1 = PlayerControls.deathCount2 = PlayerControls.deathCount3 = 0;
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
