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


    private NavMeshAgent agent;
    private Queue<string> destinations = new Queue<string>();

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (GameManager.instance != null)
        {
            if (GameManager.instance.scheduleList.Count > 0)
            {
                foreach (var schedule in GameManager.instance.scheduleList)
                {
                    destinations.Enqueue(schedule);
                    Debug.Log(schedule);
                }                
            }
        }
        //테스트 케이스
        //destinations.Enqueue("gunja");
        //MoveToNextDestination();
        //TestNav();
    }

    private void TestNav()
    {
        destinations.Enqueue("ai_center");
        destinations.Enqueue("gunja");
    }


    public void MoveToNextDestination()
    {
        if(destinations.Count == 0)
        {
            agent.isStopped = true;
        }
        if(destinations.Count >0)
        {
            string name = destinations.Dequeue();
            agent.SetDestination(BuildingName(name).transform.position);
        }
    }

    private GameObject BuildingName(string name)
    {
        switch(name)
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

//[SerializeField] private GameObject MainGate;
//[SerializeField] private GameObject GangGae;
//[SerializeField] private GameObject Student;
//[SerializeField] private GameObject AI_Center;
//[SerializeField] private GameObject Sejong;
//[SerializeField] private GameObject GunJa;
//[SerializeField] private GameObject JinKwan;
//[SerializeField] private GameObject YoungDeok;
//[SerializeField] private GameObject DaeYang;
//[SerializeField] private GameObject AejiHeon;
//[SerializeField] private GameObject ChungMuAndYulGok;
//[SerializeField] private GameObject YoungSil;
//[SerializeField] private GameObject JipHyeon;