using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int coins;
    public AudioSource audioSourse;
    public AudioClip collectSound;
    public AudioClip damageSound;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }
        
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здаровье игрока: " + health);
        if (health > 0)
        {
            audioSourse.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

    }
    public void CollectCoins()
    {
        coins++;
        audioSourse.PlayOneShot(collectSound);
        print("Ñîáðàííûå ìîíåòêè: " + coins);
    }
}
