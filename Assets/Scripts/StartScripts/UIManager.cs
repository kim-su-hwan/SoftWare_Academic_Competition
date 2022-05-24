using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager ui_instance;

    [SerializeField] private GameObject GameStartCanvas;
    [SerializeField] private GameObject MoneySettingUI;
    [SerializeField] private GameObject ScheduleSettingUI;
    [SerializeField] private TMP_Text MyMoneyUI;
    private void Awake()
    {
        if (ui_instance == null)
        {
            ui_instance = this;
        }
        else
            Destroy(this.gameObject);

        GameStartCanvas.SetActive(true);
        MoneySettingUI.SetActive(false);
        ScheduleSettingUI.SetActive(false);
    }

    //게임 탐방 시작 버튼 돈 시작 버튼으로 넘어감
    public void OnStartButton()
    {
        GameStartCanvas.SetActive(false);
        MoneySettingUI.SetActive(true);
    }
    //스케쥴 설정 UI변경 버튼
    public void OnScheduleSettingUI()
    {
        MoneySettingUI.SetActive(false);
        ScheduleSettingUI.SetActive(true);
    }
    //돈 설정 UI변경 버튼
    public void BackToMoneySetting()
    {
        ScheduleSettingUI.SetActive(false);
        MoneySettingUI.SetActive(true);
    }
    //다음 씬으로 넘어가는 버튼
    public void LoadGameScene()
    {
        SceneManager.LoadScene("MainPlayScene");
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public void UpdateMoney()
    {
        MyMoneyUI.text = $"현재 나의 돈 : {GameManager.instance.GetMoney()}";
    }
}
