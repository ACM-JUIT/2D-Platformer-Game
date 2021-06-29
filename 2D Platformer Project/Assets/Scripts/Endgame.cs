using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject player;
    void FixedUpdate()
    {
        if (player.transform.position.y <= -5.6)
        {
            Debug.Log("game over");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("game over");
        }
    }
}
