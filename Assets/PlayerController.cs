using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;
    private Vector3 rotation;

    AudioSource m_AudioSource;

    public void Update()
    {

        this.rotation = new Vector3(0, Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);
        
        bool hasHorizontalInput = !Mathf.Approximately(Input.GetAxis("Horizontal"), 0f);
        bool hasVerticalInput = !Mathf.Approximately(Input.GetAxis("Vertical"), 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;

        if (isWalking)
        {
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play();
            }
        }
        else
        {
            m_AudioSource.Stop();
        }

    }
}
