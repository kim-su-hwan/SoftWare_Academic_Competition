using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePort : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject arrivalPoint;
    
    public void TelePortLocation()
    {
        player.transform.position = arrivalPoint.transform.position;
    }
}
