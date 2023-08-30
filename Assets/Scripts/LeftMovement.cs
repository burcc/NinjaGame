using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float speed;
    BoxCollider2D box;
    float groundWidth;
    public float leftBound = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Ground"))
        {
            box = GetComponent<BoxCollider2D>();
            groundWidth = box.size.x;
        }
       
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
        
      
        if ((transform.position.x <= - groundWidth))
        {
            transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
        }
        if (gameObject.CompareTag("Obstacle"))
        {
            if (transform.position.x < leftBound)
            {
                Destroy(gameObject);
            }       
        }
        if (gameObject.CompareTag("Gold") && transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
