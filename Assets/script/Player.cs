using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    //flap force
    public float force = 300f;
  

    // Update is called once per frame
    void Update()
    {   //moving the player
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);

        }
    }
    private void OnEnable()
    {   //teleport player back to position
        if (transform.position.y < -3.9)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (col.gameObject.tag == "score")
        {
            FindObjectOfType<GameManager>().increase_score();
        }
    }
   
}
