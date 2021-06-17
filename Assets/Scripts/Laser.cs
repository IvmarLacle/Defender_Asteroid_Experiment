using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Variables for defining the laser
    public Transform firePoint;
    public GameObject laserPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    // Method for instantiating the laser
    void Shoot()
    {
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }
}
