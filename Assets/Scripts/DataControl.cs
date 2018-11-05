using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using System;

public class DataControl : MonoBehaviour
{

    public static DataControl control;
    public static int hs;
    public static int hs1;
    public static int hs2;
    public static int hs3;
    public static int hs4;
    public static int hs5;
    public static int hs6;
    public static int hs7;

    private void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
        Load();
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/playerdata.dat", FileMode.OpenOrCreate);
        PlayerData newData = new PlayerData();
        newData.hs = hs;
        newData.hs1 = hs1;
        newData.hs2 = hs2;
        newData.hs3 = hs3;
        newData.hs4 = hs4;
        newData.hs5 = hs5;
        newData.hs6 = hs6;
        newData.hs7 = hs7;
        bf.Serialize(file, newData);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerdata.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerdata.dat", FileMode.Open);
            PlayerData loadedData = (PlayerData)bf.Deserialize(file);
            file.Close();
            hs = loadedData.hs;
            hs1 = loadedData.hs1;
            hs2 = loadedData.hs2;
            hs3 = loadedData.hs3;
            hs4 = loadedData.hs4;
            hs5 = loadedData.hs5;
            hs6 = loadedData.hs6;
            hs7 = loadedData.hs7;
        }
    }
}

[Serializable]
class PlayerData
{
    public int hs;
    public int hs1;
    public int hs2;
    public int hs3;
    public int hs4;
    public int hs5;
    public int hs6;
    public int hs7;
}