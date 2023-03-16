using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWallController : MonoBehaviour
{

    public float speed = 0.5f;
    public float max_z = 15.0f;

    
    void Update()
    {
        this.gameObject.transform.Translate(0, 0, speed);
        if(this.gameObject.transform.position.z > max_z || this.gameObject.transform.position.z < (-max_z))
        {
            speed *= -1;
        }
        
    }
}
