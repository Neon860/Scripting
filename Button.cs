using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animation button;
    public Animation toOpen;
    // Start is called before the first frame update
    void Start()
    {
        button.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        button.enabled = true;
        toOpen.enabled = true;
    }
}
