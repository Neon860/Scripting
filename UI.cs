using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        scoreText.text = Player.score.ToString();
    }
}
