using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    float moveSpeed;

    Rigidbody2D rb;
            
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // moveSpeed = Random.Range(-35f, -50f);
        rb.velocity = new Vector2(-100f, 0.0f);
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
