using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [HideInInspector] public static int money = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }

    public void ReduceMoney(int amount)
    {
        money -= amount;
        if (money <= 0)
            money = 0;
    }

    public int GetMoney()
    {
        return money;
    }

}
