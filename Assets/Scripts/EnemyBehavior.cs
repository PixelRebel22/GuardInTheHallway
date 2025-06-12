using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour {

    //Allows for assigning a navMeshAgent reference
    public NavMeshAgent navMeshAgent;

    //Creates a public variable called waypoints
    public Transform[] waypoints;

    //Creates an integer variable that keeps track of the current waypoint
    int m_CurrentWaypointIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets the initial destionation to the navMeshAgent
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            //Adds one to the current index but sets it equal to zero when the increment equals the number of elements in the array
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        }
    }


}

