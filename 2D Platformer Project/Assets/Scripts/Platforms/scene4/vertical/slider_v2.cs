using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider_v2 : MonoBehaviour
{
    float movespeed = 1.5f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y > 5.8)
            moveUp = false;
        if (transform.position.y < 1)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(11.6f, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(11.6f, transform.position.y - movespeed * Time.deltaTime);
    }
}
