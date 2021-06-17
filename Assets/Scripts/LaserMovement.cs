using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    // Variables for laser movement
    public float speed;
    public Rigidbody2D rbLaser;

    // Use this for initialization
    void Start()
    {
        rbLaser.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*IDamageable damageable = Transform.gameObject.GetComponent();
  
        if (damageable != null)
    {
        damageable.TakeDamage(5);
    }*/
}
