using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionArrow : MonoBehaviour
{
    public enum SchoolFunctions
    {
        Nothing,
        Print,
        Cafe,
        Cafeteria,
        Certification,
        BookStore,
        ConvenienceStore
    };
    //enum 설정
    public SchoolFunctions functions = SchoolFunctions.Nothing;
    //화살표 프리팹
    [SerializeField] private GameObject arrow;
    private List<GameObject> arrows = new List<GameObject>();
    //원하는 위치 생성

    //[SerializeField] private GameObject GangGae;
    [SerializeField] private GameObject Student;
    //[SerializeField] private GameObject AI_Center;
    //[SerializeField] private GameObject Sejong;
    //[SerializeField] private GameObject GunJa;
    //[SerializeField] private GameObject JinKwan;
    //[SerializeField] private GameObject DongCheon;
    //[SerializeField] private GameObject ChungMuAndYulGok;
    //[SerializeField] private GameObject YoungSil;

    public void setFunctionPrint()
    {
        functions = SchoolFunctions.Print;
        SchoolFunction(functions);
    }

    public void setFunctionCafe()
    {
        functions = SchoolFunctions.Cafe;
        SchoolFunction(functions);
    }

    public void setFunctionCafeteria()
    {
        functions = SchoolFunctions.Cafeteria;
        SchoolFunction(functions);
    }

    public void setFunctionCertification()
    {
        functions = SchoolFunctions.Certification;
        SchoolFunction(functions);
    }

    public void setFunctionBookstore()
    {
        functions = SchoolFunctions.BookStore;
        SchoolFunction(functions);
    }

    public void setFunctionConvenienceStore()
    {
        functions = SchoolFunctions.ConvenienceStore;
        SchoolFunction(functions);
    }

    public void SchoolFunction(SchoolFunctions mode)
    {
        switch(mode)
        {
            case SchoolFunctions.Nothing:
                break;
            case SchoolFunctions.Print:
                break;
            case SchoolFunctions.Cafe:
                InstantiationArrow(Student);
                break;
            case SchoolFunctions.Cafeteria:
                break;
            case SchoolFunctions.Certification:
                break;
            case SchoolFunctions.BookStore:
                break;
            case SchoolFunctions.ConvenienceStore:
                break;
            default:
                break;
        }
    }

    private void InstantiationArrow(GameObject location)
    {
        arrows.Add(Instantiate(arrow, new Vector3(location.transform.position.x, location.transform.position.y, location.transform.position.z), Quaternion.Euler(new Vector3(-90f, 0f, 0f))));
        OnArrow();
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
        foreach (var obj in arrows)
            obj.SetActive(true);
    }



}
