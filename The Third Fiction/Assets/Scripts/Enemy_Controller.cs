using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{

    public int enemyHealth;
    public int currentEnemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentEnemyHealth = enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DamageTaken(int damage)
    {
        currentEnemyHealth -= damage;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            DamageTaken(50);
        }
    }


}
