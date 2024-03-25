using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float MasterVol;
    public float SFXVol;
    public float MusicVol;
    public bool Music; 


    public static LevelManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("dont destroy");

        }
        else
        {
            print("do destroy");
            Destroy(gameObject);
        }


    }
}