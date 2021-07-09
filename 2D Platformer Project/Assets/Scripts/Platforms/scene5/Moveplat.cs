using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplat : MonoBehaviour
{
    public Sliding_v slider;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            slider.enabled = true;
        }
    }

}
