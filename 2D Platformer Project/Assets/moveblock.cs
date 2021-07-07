using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveblock : MonoBehaviour
{
    public GameObject throne;
    
    void Update()
    {
        transform.position = new Vector2(throne.transform.position.x, throne.transform.position.y + 1.15f);
    }
}
