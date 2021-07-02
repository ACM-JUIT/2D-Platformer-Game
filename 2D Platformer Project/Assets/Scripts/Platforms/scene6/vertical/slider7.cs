using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider7 : MonoBehaviour
{
    float movespeed = 1f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y > 1)
            moveUp = false;
        if (transform.position.y < -3.5)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(-3f, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(-3f, transform.position.y - movespeed * Time.deltaTime);
    }
}
