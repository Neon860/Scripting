using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    //�������� NCP
    int health = 5;

    //������� NCP
    int level = 1;

    //C������� NCP
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
