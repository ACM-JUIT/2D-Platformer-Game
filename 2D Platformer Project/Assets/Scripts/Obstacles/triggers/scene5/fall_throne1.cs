using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_throne1 : MonoBehaviour
{
    Rigidbody2D rb;
    public GameManager manager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rb.isKinematic = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            manager.Restart();
        }
    }

    }
