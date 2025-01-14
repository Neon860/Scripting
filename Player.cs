using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSourse;
    public AudioClip collectSound;

    public void CollectSoins() 
    {
        coins++;
        audioSourse.PlayOneShot(collectSound);
        print("Собранные монетки: " + coins);
    }
}
