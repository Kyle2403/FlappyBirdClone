using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScirpt logic;
    public AudioScript audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioScript>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScirpt>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            BirdScript bird = collision.gameObject.GetComponent<BirdScript>();
            if (bird.IsAlive())
            {
                logic.addScore(1);
                audio.playEffect("score");
            }
        }
    }   
}
