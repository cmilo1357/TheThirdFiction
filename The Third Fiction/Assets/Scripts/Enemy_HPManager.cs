﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_HPManager : MonoBehaviour
{
    // Variables del Enemigo
    public Animator anim;
    public Enemy_UIManager Enemy_UI;
    public GameObject Object;
    public int Health;
    public int MaxHealth;


    void Awake()
    {
        anim = GetComponent<Animator>();
        Enemy_UI = GetComponent<Enemy_UIManager>();
    }

    //Activar la animacion cuando la Vida llega a 0
    //La animacion de "Explosion" tiene un evento que destruye el objeto.
    void Update()
    {
        if(Health <= 0)
        {
            anim.SetBool("IsDeath", true);
        }
    }

    //La animacion activa esta funcion en un evento.
    public void DestroyOnTime()
    {
        Destroy(Object);
    }

    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        Enemy_UI.HP_Update();
    }
}
