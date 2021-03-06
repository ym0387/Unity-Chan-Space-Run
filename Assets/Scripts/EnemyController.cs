using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //目的地となるオブジェクトのトランスフォーム格納用
    public Transform target;
    //エージェントとなるオブジェクトのNavMeshAgent格納用
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }
}
