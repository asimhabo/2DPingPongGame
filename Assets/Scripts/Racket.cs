using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour
{
    protected Rigidbody2D rb2;
    public float movespeed;
    public string moveAxisName;
    int score;
    public Text ScoreText;
    
    protected void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(moveAxisName);
        rb2.velocity = new Vector2(0, moveAxis) * movespeed;
    }

    public void MakeScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
