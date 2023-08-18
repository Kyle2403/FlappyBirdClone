using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public LogicScirpt logic;
    public float strength;
    public bool alive = true;
    public AudioScript audio;
    // Start is called before the first frame update
    public void Start()
        
    {
        audio.playTheme();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScirpt>();
    }

    // Update is called once per frame
    public void Update()
    {
        
        float y = gameObject.transform.position.y;
        if ( y < -15)
        {
            alive = false;
            logic.gameOver();
            
        }
        if (alive)
        {
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                audio.playEffect("flap");
                rigidbody.velocity = Vector2.up * strength;
            }
        }

    
        
        

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        audio.playEffect("hit");
        logic.gameOver();
        alive = false;
    }

    public bool IsAlive()
    {
        return alive;
    }
}
