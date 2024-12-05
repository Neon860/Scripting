using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    //Çäîðîâüí NCP
    int health = 5;

    //Óðîâåíü NCP
    int level = 1;

    //Cêîðîñòü NCP
    float speed = 1.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
