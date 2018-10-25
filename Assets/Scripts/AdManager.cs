using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class AdManager : MonoBehaviour {

    private bool ok = false;

    // Use this for initialization
    void Start() {
        if (PlayerControls.ad % 5 == 0 && PlayerControls.ad != 0)
        {
            if (Advertisement.IsReady("video"))
            {
                Time.timeScale = 0f;
                PauseMenu.GameIsPaused = true;
                ok = true;
                Advertisement.Show("video");
            }
        }
    }

    // Update is called once per frame
    void Update() {
        if (Advertisement.isShowing == false && PauseMenu.GameIsPaused && ok)
        {
            Time.timeScale = 1f;
            PauseMenu.GameIsPaused = false;
            ok = false;
        }
    }
}
