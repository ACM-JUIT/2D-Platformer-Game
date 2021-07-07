using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplat2 : MonoBehaviour
{
    public Sliding_v slider;
    public GameObject plat;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            slider.enabled = true;
            plat.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
