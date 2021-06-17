using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAsteroid : MonoBehaviour
{
    [SerializeField] private float speed, turnspeed;
    [SerializeField] private bool mouseEnabled;

    private float xMin, xMax, yMin, yMax;

    private Rigidbody2D rigidbody2D;

    private float steer, steerV;
    
    // Use this for initialization
    void Start ()
    {
        SetUpBoundaries();
        SetUpComponents();
    }

    // Update is called once per frame
    void Update ()
    {
        Move();
    }

    void SetUpComponents()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void SetUpBoundaries()
    {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 left = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 right = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        Vector3 up = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance));
        Vector3 down = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        
        xMin = left.x;
        xMax = right.x;
        yMin = down.y;
        yMax = up.y;
    }

    void Move()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        //bewegen naar voren of achteren
        rigidbody2D.AddForce(transform.up * vertical * speed);
        
        //3 varianten op draaien, met of zonder physics
        rigidbody2D.AddTorque(-horizontal * Time.deltaTime * turnspeed);
        //transform.Rotate(0,0,-horizontal * Time.deltatime * turnspeed);
        //rigidbody2D.rotation -= horizontal * turnspeed;
    }
        
}
