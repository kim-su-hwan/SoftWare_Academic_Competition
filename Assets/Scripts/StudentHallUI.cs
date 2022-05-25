using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudentHallUI : MonoBehaviour
{
    [SerializeField] private GameObject mainUI;
    [SerializeField] private GameObject menuUI;

    SavePlayerPos playerPosData;

    public void OnMenuUI()
    {
        mainUI.SetActive(false);
        menuUI.SetActive(true);
    }

    public void OnMainUI()
    {
        menuUI.SetActive(false);
        mainUI.SetActive(true);
    }

    public void Exit()
    {

        SceneManager.LoadScene("SchoolScene");
    }
}
