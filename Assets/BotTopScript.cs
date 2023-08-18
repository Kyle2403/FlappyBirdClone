using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotTopScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHeight(float height)
    {
        Vector3 newHeight = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
        transform.position = newHeight;
    }
}
