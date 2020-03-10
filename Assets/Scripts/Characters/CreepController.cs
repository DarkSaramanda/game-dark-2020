using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CreepController : CombatGameObject
{
    
    NavMeshAgent agent;
    GameObject finalTarget;


    protected override void Awake()
    {
        base.Awake();
        agent = GetComponent<NavMeshAgent>();
        GameObject obj = GameObject.FindWithTag("Finish");
        if (obj != null)
        {
            finalTarget = obj;
        }
    }
    
    // Update is called once per frame
    void Start()
    {
        if (finalTarget != null)
        {
            agent.SetDestination(finalTarget.transform.position);
        }
    }
}
