using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wand : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public AudioClip Magic;
    public AudioSource audioMagic;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
            audioMagic.PlayOneShot(Magic);

        }
    }
}