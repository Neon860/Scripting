using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    //public float jumpFactor = 2;

    void OnTriggerEnter(Collider Player)
    {
        Player.GetComponent<Jump>().jumpStrength *= 20;
    }

    void OnTriggerExit(Collider Player)
    {
        Player.GetComponent<Jump>().jumpStrength /= 10;
    }
}
