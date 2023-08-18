using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public GameObject smallPipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height =10;
    private int pipeCount=0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        spawnPipe();
        
    }
    void spawnPipe()
    {
        float lowest = transform.position.y - height;
        float highest = transform.position.y + height;
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            pipeCount++;
            if (pipeCount%2==0)
            {
                Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), transform.position.z), transform.rotation);
            }
            else
            {
                Instantiate(smallPipe, new Vector3(transform.position.x, Random.Range(lowest, highest), transform.position.z), transform.rotation);
            }
            timer = 0;
        }
    }
}
