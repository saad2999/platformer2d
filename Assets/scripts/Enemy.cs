using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 15f;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        speed = -speed;
        transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)), 1);
    }
}
