using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerConroller : MonoBehaviour
{
    NavMeshAgent agent;
    Camera cam;
    public LayerMask walkableLayer;

    void Start()
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
