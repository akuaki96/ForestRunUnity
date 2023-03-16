using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLoadlController : MonoBehaviour
{
    public float speed = 0.1f;
    public float max_y = 13.0f;
    public float min_y = 5.0f;

    void Update()
    {
        this.gameObject.transform.Translate(0, speed, 0);
        if(this.gameObject.transform.position.y > max_y || this.gameObject.transform.position.y < min_y)
        {
            speed *= -1;
        }

        
    }
}
