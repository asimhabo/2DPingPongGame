using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacketAI : Racket
{
    
    public Transform ball;
  

    protected override void FixedUpdate()
    {
        float distanceFromBallY = Mathf.Abs(ball.position.y - transform.position.y);
        if (distanceFromBallY > 2)
        {
            if (ball.position.y < transform.position.y)
            {
                rb2.velocity = Vector2.down * movespeed;
            }
            else
                rb2.velocity = Vector2.up * movespeed;
        }
       
    }
}
