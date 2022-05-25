using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UpdateMoneyTmp : MonoBehaviour
{
    [SerializeField] private TMP_Text money;
    [SerializeField] private GameObject menu_canvas;
    [SerializeField] private GameObject addMenu_canvas;

    private void Start()
    {
        UpdateMoneyText();
        OnMenuScene();
        OffAddMenuScene();
    }
    public void UpdateMoneyText()
    {
        money.text = $"남은 돈 : {GameManager.instance.GetMoney()}";
    }
    public void OffMenuScene()
    {
        menu_canvas.SetActive(false);
    }

    public void OnMenuScene()
    {
        menu_canvas.SetActive(true);
    }
    public void OffAddMenuScene()
    {
        addMenu_canvas.SetActive(false);
    }

    public void OnAddMenuScene()
    {
        addMenu_canvas.SetActive(true);
    }
}
