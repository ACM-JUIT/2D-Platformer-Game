using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break1 : MonoBehaviour
{
    public GameObject platform;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("fall", 3f);
            Invoke("reoccur", 10f);
        }
    }
    private void fall()
    {
        platform.GetComponent<BoxCollider2D>().enabled = false;
        platform.GetComponent<SpriteRenderer>().enabled = false;
    }
    private void reoccur()
    {
        platform.GetComponent<BoxCollider2D>().enabled = true;
        platform.GetComponent<SpriteRenderer>().enabled = true;
    }
}
