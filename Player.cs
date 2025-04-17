using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int score = 0;
    public static List<Square> squares;

    public static void Defeat()
    {
        score = 0;
    }

    private void OnMouseDown()
    {
        
    }

    void Awake()
    {
       squares = new List<Square>();

    }
}
