using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneQuit : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;

    public void OnMenuCanvas()
    {
        menuCanvas.SetActive(true);
    }
    public void OffMenuCanvas()
    {
        menuCanvas.SetActive(false);
    }

    public void LoadMainScene()
    {
        SceneControll.scene_instance.ReleasePlayer();
        SceneManager.LoadScene("SampleScene");
    }
}
