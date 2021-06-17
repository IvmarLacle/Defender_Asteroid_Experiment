using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    private bool id;
    private int health = 100;
    private int damage = 100;
    
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        id = CompareTag("EnemyShip");
    }

    // Update is called once per frame
    void Update()
    {
        Die();
        Move();
    }

    void Move()
    {
        
    }

    void Health()
    {
        if (health > 99)
        {
            Debug.Log("Alive 'n thriving");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Ya dead");
        }
    }

    void Die()
    {
        
    }

    void Shoot()
    {
        
    }


}
