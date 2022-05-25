using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchoolUI : MonoBehaviour
{
    SavePlayerPos playerPosData;

    private void Start()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
    }

    public void LoadStudentHallScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("StudentHall");
    }

    public void LoadGunjaScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Gunja");
    }
}
