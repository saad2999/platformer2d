using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed=4f;
    playermove player;
    float sign;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playermove>();
        sign = player.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(sign * speed * Time.deltaTime,0,0);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        Destroy(gameObject);
        Debug.Log("collision");
    }
}
