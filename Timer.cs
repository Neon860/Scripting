using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minubes;
    public float secends;

    // Update is called once per frame
    void Update()
    {
        secends -= Time.deltaTime;
        if (secends == 0)
        {
            if (secends <= 0)
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
            else
            {
                secends += 59;
                minubes--;
            }

        }
    }
}
