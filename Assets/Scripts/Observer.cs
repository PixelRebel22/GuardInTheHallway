using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Observer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        
        Vector3 direction = player.position - transform.position;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, direction, out raycastHit))
        {

            if (Physics.Raycast(transform.position, fwd, 4) == player)
            {
                Debug.Log("Seen!");
                // enemy can see the player!
            }
            //else
           // {
           //     Debug.Log("Must have been the wind");
                // there is something obstructing the view
            //}

        }

    }

}
