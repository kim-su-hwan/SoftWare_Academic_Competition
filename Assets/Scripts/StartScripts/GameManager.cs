﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private List<string> iventory_name = new List<string>();
    private List<int> iventory_count = new List<int>();

    [HideInInspector] public List<string> scheduleList = new List<string>();

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
        Debug.Log(money);
    }

    public int GetMoney()
    {
        return money;
    }

    public void GetIven(string item_name)
    {
        bool check_same = false;
        for(int i =0;i<iventory_name.Count;i++)
        {
            if(item_name == iventory_name[i])
            {
                iventory_count[i]++;
                check_same = true;
            }
        }
        if(check_same==false)
        {
            iventory_name.Add(item_name);
            iventory_count.Add(1);
        }
    }

    public void AddSchedule(string name)
    {
        scheduleList.Add(name);
    }

    public void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("p_x");
        PlayerPrefs.DeleteKey("p_y");
        PlayerPrefs.DeleteKey("p_z");
        PlayerPrefs.DeleteKey("TimeToLoad");
        PlayerPrefs.DeleteKey("Saved");
    }
}
