using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneQuit : MonoBehaviour
{
    public void LoadMainScene()
    {
        Debug.Log("loadmainscene");
        SceneManager.LoadScene("SampleScene");
    }
}
