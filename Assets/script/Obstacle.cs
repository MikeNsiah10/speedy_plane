using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //moving the obstacles
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x)
        {
            Destroy(gameObject);
        }

    }
}
