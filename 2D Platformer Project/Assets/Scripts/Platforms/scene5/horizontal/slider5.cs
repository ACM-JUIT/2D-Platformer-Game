using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider5 : MonoBehaviour
{
    float movespeed = 1f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y > -0.5)
            moveUp = false;
        if (transform.position.y < -3)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(4.5f, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(4.5f, transform.position.y - movespeed * Time.deltaTime);
    }
}
