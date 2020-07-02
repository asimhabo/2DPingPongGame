using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb2;
    public float movespeed;
    public Racket rightRacket, leftRacket;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * movespeed;
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        if (collision.gameObject.tag == "leftWall")
        {
            rightRacket.MakeScore();
        }
        if (collision.gameObject.tag == "rightWall")
        {
            leftRacket.MakeScore();
        }
        if (collision.gameObject.tag == "rightRacket")
        {
            CalculateReturnVelocity(-1,collision);
        }
        if (collision.gameObject.tag == "leftRacket")
        {
            CalculateReturnVelocity(1,collision);
        }
    }

    private void CalculateReturnVelocity(float x , Collision2D collision)
    {
        float a = transform.position.y - collision.collider.bounds.center.y;
        float b = collision.collider.bounds.size.y;
        float y = a / b;

        rb2.velocity = new Vector2(x, y) * movespeed;
    }
}
