using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public Transform orientation;
    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;

    [Header("Ground Check")]
    public float groundDrag;
    public float playerHeight;
    public LayerMask groundCheck;
    bool grounded;

    [Header("Jumping")]
    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("KeyBinds")]
    public KeyCode jumpKey = KeyCode.Space;
    
    Rigidbody rb;


    private void Start()
    {
        //Gets RigidBody from player and freezes rotations
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        //lets player jump
        readyToJump = true;
    }

    private void Update()
    {
        //Ground Checks
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, groundCheck);

        //Checks for player inputs each frame
        InputChecks();
        SpeedControl();


        //Add drag
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void FixedUpdate()
    {
        //Moves player
        MovePlayer();
    }

    private void InputChecks()
    {
        //Get players keyboard inputs
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //Checks and executes jumps
        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        //Calculate movement direction
        moveDirection =  orientation.forward * verticalInput + orientation.right * horizontalInput;

        //Move Player on ground
        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10F, ForceMode.Force);
        }

        else if (!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10F * airMultiplier, ForceMode.Force);
        }

    }

    private void SpeedControl()
    {
        //get normalised velocity
        Vector3 flatVel = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        //limit velocity
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel  = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        //Resets Y Velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //Performs jump
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        //Removes restriction blocking jumping
        readyToJump = true;
    }
}
