using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMestControll : MonoBehaviour
{
    enum Building
    {
        MainGate,
        GangGae,
        Student,
        AI_Center,
        Sejong,
        GunJa,
        JinKwan,
        YoungDeok,
        DaeYang,
        AejiHeon,
        DongCheon,
        ChungMuAndYulGok,
        YoungSil,
        JipHyeon
    }

    [SerializeField] private GameObject MainGate;
    [SerializeField] private GameObject GangGae;
    [SerializeField] private GameObject Student;
    [SerializeField] private GameObject AI_Center;
    [SerializeField] private GameObject Sejong;
    [SerializeField] private GameObject GunJa;
    [SerializeField] private GameObject JinKwan;
    [SerializeField] private GameObject YoungDeok;
    [SerializeField] private GameObject DaeYang;
    [SerializeField] private GameObject AejiHeon;
    [SerializeField] private GameObject DongCheon;
    [SerializeField] private GameObject ChungMuAndYulGok;
    [SerializeField] private GameObject YoungSil;
    [SerializeField] private GameObject JipHyeon;

    [SerializeField] private GameObject schedule;

    [HideInInspector] public NavMeshAgent agent;
    private Queue<string> destinations = new Queue<string>();
    public Queue<string> Destinations => destinations;
    private string name;
    public string Name => name;
    private bool isDoing = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        checkArrive();

    }

    private void checkArrive()
    {
        if (isDoing)
        {
            if (!agent.pathPending)
            {
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        isDoing = false;
                        agent.ResetPath();
                        schedule.GetComponent<ShowSchedule>().UpdateSchedule();
                    }
                }
            }
        }
    }

    public void MoveToNextDestination()
    {
        if (GameManager.instance.scheduleList.Count == 0)
            return;

        if (GameManager.instance.scheduleList.Count > 0)
        {
            isDoing = true;
            name = GameManager.instance.scheduleList.Dequeue();
            agent.SetDestination(BuildingName(name).transform.position);
        }
    }

    private GameObject BuildingName(string name)
    {
        switch (name)
        {
            case "maingate":
                return MainGate;
            case "ganggae":
                return GangGae;
            case "student":
                return Student;
            case "ai_center":
                return AI_Center;
            case "sejong":
                return Sejong;
            case "gunja":
                return GunJa;
            case "jinkwan":
                return JinKwan;
            case "youngdeok":
                return YoungDeok;
            case "daeyang":
                return DaeYang;
            case "aejiheon":
                return AejiHeon;
            case "dongcheon":
                return DongCheon;
            case "chungmuandyulgok":
                return ChungMuAndYulGok;
            case "youngsil":
                return YoungSil;
            case "jiphyeon":
                return JipHyeon;
            default:
                return null;
        }
    }
}
