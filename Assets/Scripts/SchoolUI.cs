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

    public void LoadGanggaeScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Ganggae");
    }

    public void LoadAICenterScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("AI");
    }

    public void LoadJinkwanScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Jinkwan");
    }

    public void LoadDongcheonScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Dongcheon");
    }

    public void LoadYulgokScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Yulgok");
    }

    public void LoadChungmuScene()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Chungmu");
    }
}
