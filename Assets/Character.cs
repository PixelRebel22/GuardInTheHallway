using UnityEngine;

public class Character : MonoBehaviour
{
    private UnityEngine.CharacterController controller;

    public float Speed = 5f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        controller.Move(move * Time.deltaTime * Speed);
    }
}
