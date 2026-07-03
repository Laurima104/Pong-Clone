using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameType : MonoBehaviour
{
    public static GameType instancia;
    public bool MLocal = false;

    void Awake()
    {
        if(instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
}
