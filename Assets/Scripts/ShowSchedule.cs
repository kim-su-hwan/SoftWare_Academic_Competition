using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowSchedule : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI schedule;

    void Start()
    {
        UpdateSchedule();
    }

    public void UpdateSchedule()
    {
        //Queue<string> dest = player.GetComponent<NavMestControll>().Destinations;
        if (GameManager.instance.scheduleList.Count == 0)
        {
            schedule.text = "다음 스케쥴:";
        }
        else if (GameManager.instance.scheduleList.Count > 0)
        {
            string name = GameManager.instance.scheduleList.Peek();
            schedule.text = BuildingName(name);
        }
    }

    private string BuildingName(string name)
    {
        switch (name)
        {
            case "ganggae":
                return "다음 스케쥴:\n광개토관";
            case "student":
                return "다음 스케쥴:\n학생회관";
            case "ai_center":
                return "다음 스케쥴:\n대양AI센터";
            case "sejong":
                return "다음 스케쥴:\n세종관";
            case "gunja":
                return "다음 스케쥴:\n군자관";
            case "jinkwan":
                return "다음 스케쥴:\n진관홀";
            case "daeyang":
                return "다음 스케쥴:\n대양홀";
            case "aejiheon":
                return "다음 스케쥴:\n애지헌";
            case "dongcheon":
                return "다음 스케쥴:\n학술정보원";
            case "chungmuandyulgok":
                return "다음 스케쥴:\n충무/율곡관";
            case "youngsil":
                return "다음 스케쥴:\n영실관";
            case "youngdeok":
                return "다음 스케쥴:\n용덕관";
            case "jiphyeon":
                return "다음 스케쥴:\n집현관";
            default:
                return null;
        }
    }
}
