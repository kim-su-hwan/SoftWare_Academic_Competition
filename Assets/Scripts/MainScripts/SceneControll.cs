using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    public static SceneControll scene_instance;
    [SerializeField] private GameObject player;
    private static Transform savePosition;

    private void Awake()
    {
        if (scene_instance == null)
        {
            scene_instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);               
    }


    void SavePosition()
    {
        savePosition.position = player.transform.position;
    }

    public void SetPosition()
    {
        player.transform.position = savePosition.position;
    }


    public void LoadCafeteriaScene()
    {
        SceneManager.LoadScene("CafeteriaScene");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
