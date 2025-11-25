using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorenet : MonoBehaviour
{
    [SerializeField] Scorecounter scoreCounter;
    [SerializeField] BallMovement ball;
   
   private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreCounter.score++;
        ball.transform.position = ball.startPos;
        ball.launch();
    }
}
