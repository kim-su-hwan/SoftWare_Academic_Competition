using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuctionArrow : MonoBehaviour
{
    public enum SchoolFuctions
    {
        Nothing,
        Print,
        Cafe,
        Cafeteria,
        Certification,
        BookStore,
        Restorant,
        ConvenienceStore,
        StudyRoom
    };
    //enum 설정
    public SchoolFuctions fuctions = SchoolFuctions.Nothing;
    //화살표 프리팹
    [SerializeField] private GameObject arrow;
    private List<GameObject> arrows = new List<GameObject>();
    //원하는 위치 생성
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

    public void SchoolFuntion(SchoolFuctions mode)
    {
        switch(mode)
        {
            case SchoolFuctions.Nothing:
                break;
            case SchoolFuctions.Print:
                break;
            case SchoolFuctions.Cafe:
                break;
            case SchoolFuctions.Cafeteria:
                break;
            case SchoolFuctions.Certification:
                break;
            case SchoolFuctions.BookStore:
                break;
            case SchoolFuctions.Restorant:
                break;
            case SchoolFuctions.ConvenienceStore:
                break;
            case SchoolFuctions.StudyRoom:
                break;

            default:
                break;
        }
    }

    private void InstantiationArrow(GameObject location)
    {
        arrows.Add(Instantiate(arrow, new Vector3(location.transform.position.x, location.transform.position.y, location.transform.position.z), Quaternion.Euler(new Vector3(-90f, 0f, 0f))));
    }

    public void DestroyArrow()
    {
        foreach(var obj in arrows)
        {
            Destroy(obj);
        }
    }
    private void OnArrow()
    {
        arrow.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1f, gameObject.transform.position.z);
        arrow.transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, 0f));
        arrow.SetActive(true);
    }



}
