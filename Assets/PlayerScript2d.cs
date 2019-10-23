using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript2d : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rd;

    [SerializeField] private bool jump = false;
    [SerializeField] private bool doubleJump = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if (!jump && Input.GetKeyDown("space"))
        {
            rd.AddForce(Vector2.up * 200);
            jump = true;
        }
        else
        {
            if (!doubleJump && Input.GetKeyDown("space"))
            {
                
                rd.AddForce(Vector2.up * 200);
                doubleJump = true; 
            }
        }
        if (Math.Abs(transform.position.x+x)>7)
            rd.velocity= Vector2.zero;
        else
        {
            rd.velocity=(new Vector2(x*10,rd.velocity.y) );

        }

        //rd.velocity = new Vector2(x, y);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("wqe");
        jump = false;
        doubleJump = false;
    }
}