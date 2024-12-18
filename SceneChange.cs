using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

using System.Security.Cryptography.X509Certificates;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    void OnTriggerStay(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}

    
