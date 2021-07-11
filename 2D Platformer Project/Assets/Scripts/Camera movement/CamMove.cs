using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        transform.position = new Vector2(player.transform.position.x + 4f, player.transform.position.y + 1.1f);
    }
}
