using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    private Renderer render;
    private Collider2D collider;
    private float numero = 1.5f;


    void Awake()
    {
        anim = GetComponent<Animator>();
        render = GetComponent<Renderer>();
        collider = GetComponent<Collider2D>();
    }

    public void Update()
    {
        if (anim.GetBool("IsDeath"))
        {
            numero -= Time.deltaTime;
            if(numero <= 0) { Destroy(gameObject); }
        }
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("Bullet"))
        {
            anim.SetBool("IsDeath", true);
        }
    }

    public void DestroyOnTime()
    {
        render.enabled = false;
        collider.enabled = false;
    }
}
