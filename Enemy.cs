using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    public float health = 10;
    private GameObject player;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Health player = other.GetComponent<Health>();
        player.TakeDamage(playerDamage);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        print("Здаровье врага: " + health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
