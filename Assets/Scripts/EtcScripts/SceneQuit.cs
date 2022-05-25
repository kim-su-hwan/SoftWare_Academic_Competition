using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneQuit : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneControll.scene_instance.ReleasePlayer();
        SceneManager.LoadScene("SampleScene");
    }
}
