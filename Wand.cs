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
    public int mana = 10;
    public int maxMana = 10;
    public float recoveryTimer = 3;
    public float recoveryDelay = 3;
    
    public void Update()
    {
        if (mana >= 5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
                audioMagic.PlayOneShot(Magic);
                mana -= 5;             
            }
        }

        if (mana < 10)
        {
            if (recoveryTimer <= 0)
            {
                mana += 1;
                recoveryTimer += recoveryDelay;
            }
            else
            {
                recoveryTimer -= Time.deltaTime;
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            mana += 1;
        }
    }
}
