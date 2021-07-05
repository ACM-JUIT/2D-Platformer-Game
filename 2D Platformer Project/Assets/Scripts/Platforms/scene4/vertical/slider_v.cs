using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider_v : MonoBehaviour
{
    float movespeed = 1.5f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y > 3.3)
            moveUp = false;
        if (transform.position.y < -1)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(-10f, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(-10f, transform.position.y - movespeed * Time.deltaTime);
    }
}
