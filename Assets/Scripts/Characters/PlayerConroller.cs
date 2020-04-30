using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using NavGame.Core;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerConroller : TouchableGameObject
{
    NavMeshAgent agent;
    Camera cam;
    public LayerMask walkableLayer;


    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit, Mathf.Infinity, walkableLayer))
            {
                agent.SetDestination(Hit.point);
            }
        }
    }
}
