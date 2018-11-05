using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private GameMaster gm;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerControls.sceneIndex == 1)
        {
            gm.lastCheckPointPos.x = transform.position.x;
            gm.lastCheckPointPos.y = 4.28f;
        }
        else if(other.CompareTag("Player") && PlayerControls.sceneIndex == 2)
        {
            gm.lastCheckPointPos1.x = transform.position.x;
            gm.lastCheckPointPos1.y = 4.28f;
        }
        else if (other.CompareTag("Player") && PlayerControls.sceneIndex == 3)
        {
            gm.lastCheckPointPos2.x = transform.position.x;
            gm.lastCheckPointPos2.y = 4.28f;
        }
        else if (other.CompareTag("Player") && PlayerControls.sceneIndex == 4)
        {
            gm.lastCheckPointPos3.x = transform.position.x;
            gm.lastCheckPointPos3.y = 4.28f;
        }
        else if (other.CompareTag("Player") && PlayerControls.sceneIndex == 5)
        {
            gm.lastCheckPointPos4.x = transform.position.x;
            gm.lastCheckPointPos4.y = 4.28f;
        }
        else if (other.CompareTag("Player") && PlayerControls.sceneIndex == 6)
        {
            gm.lastCheckPointPos5.x = transform.position.x;
            gm.lastCheckPointPos5.y = 4.28f;
        }
        else if (other.CompareTag("Player") && PlayerControls.sceneIndex == 7)
        {
            gm.lastCheckPointPos6.x = transform.position.x;
            gm.lastCheckPointPos6.y = 4.28f;
        }
        else
        {
            gm.lastCheckPointPos7.x = transform.position.x;
            gm.lastCheckPointPos7.y = 4.28f;
        }
    }
}
