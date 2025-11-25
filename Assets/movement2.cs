using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
   [SerializeField] GameObject Ball;

   Rigidbody2D rb;
   float speed = 23;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if (Ball.transform.position.y > transform.position.y)
        {
            rb.linearVelocity = new Vector2 (rb.linearVelocity.x, speed);
        }
        else if (Ball.transform.position.y < transform.position.y)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -speed);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}