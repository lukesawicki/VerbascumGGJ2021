using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerController;
    public LayerMask groundLayerMask;
    public Transform groundCheck;
    Vector3 currentVelocity;
    bool isGrounded;
    public float movementSpeed = 10.0F;
    public float gravity = -9.8F;
    public float groundDistance = 0.4F;
    public float jumpHeight = 3.0F;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);

        if (isGrounded && currentVelocity.y < 0)
        {
            currentVelocity.y = -2.0F;
        }

        float movementXaxis = Input.GetAxis("Horizontal");
        float movementZaxis = Input.GetAxis("Vertical");

        Vector3 move = transform.right * movementXaxis + transform.forward * movementZaxis;
        
        playerController.Move(move * movementSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            currentVelocity.y = Mathf.Sqrt(jumpHeight * -2.0F * gravity);
        }

        currentVelocity.y += (gravity * Time.deltaTime);
        playerController.Move(currentVelocity * Time.deltaTime);

    }
}
