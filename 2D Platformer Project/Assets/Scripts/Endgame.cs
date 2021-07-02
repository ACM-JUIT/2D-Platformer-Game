using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject player;
    public GameManager manager;
    void FixedUpdate()
    {
        if (player.transform.position.y <= -5.6)
        {
            manager.Restart();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            manager.Restart();
        }
    }
}
