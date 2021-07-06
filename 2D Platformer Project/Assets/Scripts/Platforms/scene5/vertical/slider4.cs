using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider4 : MonoBehaviour
{
    float movespeed = 1.5f;
    bool moveUp = true;

    private void Update()
    {
        if (transform.position.y >1.2)
            moveUp = false;
        if (transform.position.y < -4)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(-7.5f, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(-7.5f, transform.position.y - movespeed * Time.deltaTime);
    }
}
