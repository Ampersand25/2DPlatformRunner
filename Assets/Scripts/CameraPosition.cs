using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {

    private GameMaster gm;

    // Use this for initialization
    void Start () {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        if (PlayerControls.sceneIndex == 1)
            transform.position = gm.lastCheckPointPos;
        else if (PlayerControls.sceneIndex == 2)
            transform.position = gm.lastCheckPointPos1;
        else if (PlayerControls.sceneIndex == 3)
            transform.position = gm.lastCheckPointPos2;
        else if (PlayerControls.sceneIndex == 4)
            transform.position = gm.lastCheckPointPos3;
        else if (PlayerControls.sceneIndex == 5)
            transform.position = gm.lastCheckPointPos4;
        else if (PlayerControls.sceneIndex == 6)
            transform.position = gm.lastCheckPointPos5;
        else if (PlayerControls.sceneIndex == 7)
            transform.position = gm.lastCheckPointPos6;
        else transform.position = gm.lastCheckPointPos7;
        Time.timeScale = 1f;
    }
}
