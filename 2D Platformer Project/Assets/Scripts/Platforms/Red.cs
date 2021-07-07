using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public GameObject player;
    public GameObject trigger;
    private float red = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RedTrigger")
        {
            red = 100;
            Destroy(trigger);
        }
    }
    void FixedUpdate()
    {
        if (red == 100)
        {
            player.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

}
