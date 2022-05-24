using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDontDestroy : MonoBehaviour
{
    private static PlayerDontDestroy p_Instance = null;

    private void Awake()
    {
        if(p_Instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }

        p_Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
