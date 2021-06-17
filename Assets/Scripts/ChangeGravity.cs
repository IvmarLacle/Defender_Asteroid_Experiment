using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0f, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
