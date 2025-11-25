using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
     float speed = 35;
     Rigidbody2D rb;
     public Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        launch();
    }

    public void launch()
    {
        int x = Random.Range(0, 2);
        int y = Random.Range(0, 2);

        if (x == 0)
        {
            x = -1;
        }

        if (y == 0)
        {
            y = -1;
        }

        rb.linearVelocity = new Vector2(x * speed, y * speed);
    }
}