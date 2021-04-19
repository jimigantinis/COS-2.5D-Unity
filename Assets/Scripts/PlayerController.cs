using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Rigidbody rigidbody;
    public float moveSpeed, jumpForce;

    private Vector2 moveInput;

    public LayerMask whatIsGround;
    public Transform groundPoint;
    private bool isGrounded, run;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        rigidbody.velocity = new Vector3 (moveInput.x * moveSpeed, rigidbody.velocity.y, moveInput.y * moveSpeed);

        RaycastHit hit;
        if(Physics.Raycast(groundPoint.position, Vector3.down, out hit, .3f, whatIsGround))
        {
            isGrounded = true;
        } else {
            isGrounded = false;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidbody.velocity += new Vector3(0f, jumpForce, 0f);
        }

        if(Input.GetButtonDown("Run"))
        {
            Run();
        }

        if(Input.GetButtonUp("Run"))
        {
            Run();
        }
    }

    void Run()
    {
        if (run){
            moveSpeed = moveSpeed/2;
            run = false;
        }else{    
            moveSpeed = moveSpeed*2;
            run = true;
        }
    }           
}
