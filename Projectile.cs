using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10;

    private void Start()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            GameObject effect = Instantiate(explosionAsteroid, transform.position, transform.rotation);
            Destroy(effect, 5);
            Destroy(this.gameObject);
        }
    }
}
