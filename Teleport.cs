using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Teleport_Point;
    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = Teleport_Point.transform.position;
        }
    }
}