using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour, IInteractable
{

    public NavMeshAgent navMeshAgent; //Allows for assigning a navMeshAgent reference
    public Transform[] waypoints; //Creates a public variable called waypoints   
    public int m_CurrentWaypointIndex; //Creates an integer variable that keeps track of the current waypoint
    public bool isPaused;


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
            isPaused = true;
            StartCoroutine(PauseGuard());
            
            //Adds one to the current index but sets it equal to zero when the increment equals the number of elements in the array
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);

        }
    }

    IEnumerator PauseGuard()
    {
        navMeshAgent.isStopped = true;
        while (isPaused)
        {
            
            //Print the time of when the function is first called.
            Debug.Log("Started Coroutine at timestamp : " + Time.time);

            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(5);
            
            isPaused = false;
            //After we have waited 5 seconds print the time again.
            Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        }
        navMeshAgent.isStopped = false;
        yield return null;
    }

    public void Interact()
    {
        if (isPaused)
        {
            Debug.Log("Dialogue");
        }


        
    }

}

