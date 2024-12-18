using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TELEPORT1 : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = teleportPoint.transform.position;
        }
    }
}