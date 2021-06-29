using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider_v : MonoBehaviour
{
    float movespeed = 0.5f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y > 2.1)
            moveUp = false;
        if (transform.position.y < 0)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(-8.3f, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(-8.3f, transform.position.y - movespeed * Time.deltaTime);
    }
}
