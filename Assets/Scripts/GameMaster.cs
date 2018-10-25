using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    private static GameMaster instance;
    public Vector2 lastCheckPointPos;
    public Vector2 lastCheckPointPos1;
    public Vector2 lastCheckPointPos2;
    public Vector2 lastCheckPointPos3;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
