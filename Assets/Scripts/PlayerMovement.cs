using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
        Vector3 direction = new Vector3(horizontal, vertical, 0f).normalized; 

        if (direction.magnitude >= 0.1f)
            controller.Move(direction * speed * Time.deltaTime);
    }
}
