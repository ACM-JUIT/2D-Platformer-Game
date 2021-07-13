using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject player;
    public GameManager manager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            manager.Restart();
        }
        if (collision.gameObject.tag == "endgame")
        {
            manager.Restart();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            manager.Restart();
        }
    }
}
