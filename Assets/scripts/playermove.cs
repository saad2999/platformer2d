using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    int speed = 15;
    Rigidbody2D rb;
    Animator anim;
    float jumpheight = 12f;
    Collider2D mycollider2d;
    public GameObject bulet;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mycollider2d = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool("isrunning", true);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("isrunning", true);

        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetBool("isrunning", false);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (mycollider2d.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                rb.AddForce(Vector2.up * jumpheight, ForceMode2D.Impulse);
            }
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
           Instantiate(bulet, transform.position + new Vector3(transform.localScale.x*0.7f, 0,0), transform.rotation);
            
        }
        
    }
}
