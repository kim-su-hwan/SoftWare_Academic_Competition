using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowMoney : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI money;

    private void Start()
    {
        UpdateMoney();
    }

    public void ReduceMoney(int money)
    {
        GameManager.instance.ReduceMoney(money);
        UpdateMoney();
    }

    public void UpdateMoney()
    {
        money.text = $"남은 돈 : {GameManager.instance.GetMoney()}";   
    }



}
