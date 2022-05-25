using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunjaUI : MonoBehaviour
{
    SavePlayerPos playerPosData;

    public void Exit()
    {
        SceneManager.LoadScene("SchoolScene");
    }
}
