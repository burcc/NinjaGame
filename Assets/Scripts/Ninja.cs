using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]private float _speed;
    public Score score;
    public GameManager gameManager;
    //bool obstacleTouched;
    public Sprite ninjaDied;
    SpriteRenderer _sp;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    void Jump()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.gameOver == false)
        {
            _rb.velocity = Vector2.zero;
            _rb.velocity = new Vector2(_rb.velocity.x, _speed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gold"))
        {
            score.Scored();
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Debug.Log("died");
            
                //gameOver
                gameManager.GameOver();
            
                //gameOver(ninja)
                GameOver();
            
        }   
    }

    void GameOver()
    {
        //obstacleTouched = true;
        transform.rotation = Quaternion.Euler(0, 0, -90);
        transform.position = new Vector2(transform.position.x, -4.46f);
        //ayak hareketleri dursun
        _sp.sprite = ninjaDied;
        anim.enabled = false; //bu animasyonu durduyor
    }
}
