using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public void QuitGame()
    {
        PlayerControls.deathCount = PlayerControls.deathCount1 = PlayerControls.deathCount2 = PlayerControls.deathCount3 = 0;
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
