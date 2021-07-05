using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_plat2 : MonoBehaviour
{
    public slider_v2 slider;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            slider.enabled = true;
        }
    }
}
