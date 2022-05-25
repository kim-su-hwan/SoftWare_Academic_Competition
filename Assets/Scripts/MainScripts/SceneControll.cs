using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

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


        // tmp
        //player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        //player.GetComponent<ActionBasedContinuousTurnProvider>().enabled = false;
    }


    public void SavePosition()
    {
        //player.GetComponent<Rigidbody>().useGravity = false;
        //player.GetComponent<Rigidbody>().freezeRotation = true;
        
        //savePosition.transform.position = player.transform.position;
    }

    public void SetPosition()
    {
        //player.GetComponent<Rigidbody>().useGravity = true;
        //player.GetComponent<Rigidbody>().freezeRotation = false;
    }


    public void LoadCafeteriaScene()
    {
        SceneManager.LoadScene("CafeteriaScene");
        //player.GetComponent<Rigidbody>().useGravity = false;
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LockingPlayer()
    {
        player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        player.GetComponent<ActionBasedContinuousTurnProvider>().enabled = false;
    }
    public void ReleasePlayer()
    {
        player.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;
        player.GetComponent<ActionBasedContinuousTurnProvider>().enabled = true;
    }
}
