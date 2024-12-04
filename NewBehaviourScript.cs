using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    //Здоровьн NCP
    int health = 5;

    //Уровень NCP
    int level = 1;

    //Cкорость NCP
    float speed = 1.5f;
    void Start()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
