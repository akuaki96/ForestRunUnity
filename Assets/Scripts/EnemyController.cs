using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    public float max_x = -150;
    public float min_x = -175;


    void Update()
    {
        if(target.transform.position.x < max_x && target.transform.position.x > min_x)
        {
            agent.destination = target.position;
        }
    }


}
