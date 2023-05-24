using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rBody2D;
    public float bulletSpeed = 5;

    void Awake()
    {
        rBody2D = GetComponent<Rigidbody2D>();

        rBody2D.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
       Destroy(this.gameObject); 
    }
}