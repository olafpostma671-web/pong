using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
   float playerspeed = 40;
   Rigidbody2D rb;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, Input.GetAxisRaw("Vertical") * playerspeed);
    }
}