using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    //Stores a reference to a transform where the interacting ray is casted
    public Transform InteractorSource;
    //Takes the length of the interacting raycast
    public float InteractRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the player is pressing the 'E' key
        if(Input.GetKeyDown(KeyCode.E))
        {
            //If so, a raycast is created in the position and direction of the interactive source
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                //If the raycast detects a collider, the collision info is used to attempt an interaction with the object
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
        }

    }
}
