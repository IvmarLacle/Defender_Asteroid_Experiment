using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool mouseEnabled;

    private float xMin;
    private float xMax;

    private float yMin;
    private float yMax;

    private float steer;
    private float steerV;
    
    
    // Use this for initialization
    void Start ()
    {
        SetUpBoundaries();
    }
 
    // Update is called once per frame
    void Update ()
    {
        Move();
        Movemouse();
    }

    void SetUpBoundaries()
    {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 left = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 right = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        Vector3 up = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance));
        Vector3 down = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        //print("links: " + left + " - rechts: " + right);
        xMin = left.x;
        xMax = right.x;
        yMin = down.y;
        yMax = up.y;
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //transform.Translate(horizontal * Time.deltaTime * speed,0,0);
        steer = Mathf.Clamp((steer += horizontal * Time.deltaTime * speed), xMin, xMax);
        steerV = Mathf.Clamp((steerV += vertical * Time.deltaTime * speed), yMin, yMax);
        transform.position = new Vector2(steer, steerV);
        //transform.position = new Vector2(transform.position.x , steerV);
    }

    void Movemouse()
    {
        if (mouseEnabled)
        {
            //float mouseX = Input.GetAxis("Mouse X");
            //float mouseY = Input.GetAxis("Mouse Y");
            var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,10);
            transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
        }
        

    }

}
