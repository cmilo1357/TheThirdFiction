﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaia_Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody2D bulletRb;

    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb.velocity = transform.right*bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("Ground") || hit.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        else if (hit.gameObject.CompareTag("Enemie"))
        {
            hit.GetComponent<DestroyObject>().TakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
