using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SavePlayerPos : MonoBehaviour
{
    [SerializeField] GameObject player;

    void Start()
    {
        if (PlayerPrefs.GetInt("Saved") == 1 && PlayerPrefs.GetInt("TimeToLoad") == 1)
        {
            float pX = player.transform.position.x;
            float pY = player.transform.position.y;
            float pZ = player.transform.position.z;

            pX = PlayerPrefs.GetFloat("p_x");
            pY = PlayerPrefs.GetFloat("p_y");
            pZ = PlayerPrefs.GetFloat("p_z");

            player.GetComponent<CharacterController>().enabled = false;
            player.GetComponent<NavMeshAgent>().enabled = false;
            player.transform.position = new Vector3(pX, pY, pZ);
            player.GetComponent<CharacterController>().enabled = true;
            player.GetComponent<NavMeshAgent>().enabled = true;

            PlayerPrefs.SetInt("TimeToLoad", 0);
            PlayerPrefs.Save();

            Debug.Log("Load " + new Vector3(pX, pY, pZ));
        }
    }

    public void PlayerPosSave()
    {
        PlayerPrefs.SetFloat("p_x", player.transform.position.x);
        PlayerPrefs.SetFloat("p_y", player.transform.position.y);
        PlayerPrefs.SetFloat("p_z", player.transform.position.z);
        PlayerPrefs.SetInt("Saved", 1);
        PlayerPrefs.Save();

        Debug.Log("Save " + new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
    }

    public void PlayerPosLoad()
    {
        PlayerPrefs.SetInt("TimeToLoad", 1);
        PlayerPrefs.Save();
    }
}
