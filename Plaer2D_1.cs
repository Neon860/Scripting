using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaer2D_1 : MonoBehaviour
{
    public int points;
    public float shootInstantiate;
    public float shootTimer;
    public Projectile projectilePrefab;
    public Transform shootPoint;

    void Shoot()
    {  
        if (shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInstantiate;
        }
    }

    void Update()
    {
        Move();
        Shoot();
        shootTimer -= Time.deltaTime;
    }

    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }
}
