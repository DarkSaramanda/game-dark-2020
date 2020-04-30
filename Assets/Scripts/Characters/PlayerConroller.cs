﻿using System.Collections;
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
    public LayerMask collectibleLayer;


    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, walkableLayer))
            {
                agent.SetDestination(hit.point);
            }

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, collectibleLayer))
            {
                Debug.Log("Collectible: " + hit.collider.name);
                agent.SetDestination(hit.point);
            }
        }
    }
}
