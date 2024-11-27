using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //CUBE GOYDA//
        GameObject.CreatePrimitive
     (PrimitiveType.Cube).transform.position =
     new Vector3(0, 0, 0);
        //CUBE GOYDA//
        GameObject.CreatePrimitive
     (PrimitiveType.Cube).transform.position =
     new Vector3(-0.5f, 1, 0);
        //CUBE GOYDA//
        GameObject.CreatePrimitive
     (PrimitiveType.Cube).transform.position =
     new Vector3(0.5f, 1, 0);
        //CUBE GOYDA//
        GameObject.CreatePrimitive
     (PrimitiveType.Cube).transform.position =
     new Vector3(0.5f, 2, 0);
        //CUBE GOYDA//
        GameObject.CreatePrimitive
     (PrimitiveType.Cube).transform.position =
     new Vector3(-0.5f, 2, 0);
        //CUBE GOYDA//
        GameObject.CreatePrimitive
     (PrimitiveType.Cube).transform.position =
     new Vector3(0, 3, 0);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
