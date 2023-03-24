using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testy : MonoBehaviour
{
    public float slideForceMultiplier = 1.0f;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float sprintMultiplier = 2f;
    public float slideDuration = 1f;
    public KeyCode slideKey = KeyCode.LeftShift;
    public KeyCode sprintKey = KeyCode.Space;

    private Rigidbody rb;
    private bool isGrounded = true;
    private bool isSliding = false;
    private float slideTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Move player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        float speed = moveSpeed;
        if (Input.GetKey(sprintKey))
        {
            speed *= sprintMultiplier;
        }
        if (isSliding)
        {
            speed /= 2f;
        }
        rb.MovePosition(rb.position + transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        // Slide
        if (Input.GetKeyDown(slideKey) && !isSliding && isGrounded)
        {
            isSliding = true;
            slideTimer = slideDuration;

            // Apply force in the direction of movement
            Vector3 slideForce = new Vector3(horizontalInput, 0f, verticalInput).normalized * rb.mass * -moveSpeed * 0.25f * slideForceMultiplier;
            rb.AddForce(slideForce, ForceMode.Impulse);
        }

        // Update slide timer
        if (isSliding)
        {
            slideTimer -= Time.deltaTime;
            if (slideTimer <= 0f)
            {
                isSliding = false;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if player is grounded
        if (collision.gameObject.CompareTag("GROUND"))
        {
            isGrounded = true;
        }
    }
}
