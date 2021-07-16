using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject player;
    
    public GameManager manager;

    public Vector3 Respawnpoint;
    private void Start()
    {
        Respawnpoint = player.transform.position;
    }
    /*Endgame()
    {
        Respawnpoint = player.transform.position;
    }*/

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "CheckPoint")
        {
           Respawnpoint = col.transform.position;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Obstacle")
        {
            
            transform.position = Respawnpoint;
        }
        if (collision.gameObject.tag == "endgame")
        {
            
            transform.position = Respawnpoint;
        }
        if (collision.gameObject.tag == "Enemy")
        {
           
            transform.position = Respawnpoint;
        }
    }
}
