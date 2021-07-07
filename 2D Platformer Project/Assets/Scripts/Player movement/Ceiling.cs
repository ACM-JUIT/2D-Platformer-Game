using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceiling : MonoBehaviour
{
    public GameObject player;
    public float offset_y = 0.7f;
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x, player.transform.position.y + offset_y);
    }
}
