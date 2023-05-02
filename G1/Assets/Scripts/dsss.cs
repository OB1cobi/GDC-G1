using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BasicCC : MonoBehaviour
{
    [Header("External Refernces")]
    public Transform T_CameraObj; //The Game Camera itself
    private CharacterController CC_PlayersCC;

    [Header("Player Settings")]
    public float F_PlayerSpeed; //Custom Player Speed
    public float F_Accerlation; // is the change of current speed over time
    public float F_PlayerLowestTurnSpeed; // player turn speed of rotation
    public float F_PlayerTurnSpeed; // player turn speed of rotation
    public float F_PlayerHighestTurnSpeed; // player turn speed of rotation
    public float F_PlayerGravity; //Force to push the player back to ground
    public float F_OnGroundGravity;
    public float F_PlayerJumpHeight; //max jump height

    [Header("Stored Player Information")]
    public float F_CurrentAngle;
    public float F_CurrentTurnSpeed;
    public bool B_PlayerIsGrounded;
    private RaycastHit RCH_AmITouching; //Information that the bottom of the character is grounded or not
    public Vector2 V2_Input; //Used to store Player input from the InputManager
    public Vector3 V3_IntendedDirection; //Stores intended direction the player is expected to be going
    public Vector3 V3_Velocity; //Current Player speed
    public Vector3 V3_VelocityXZ; //Current Player speed
    public Quaternion Q_PlayerRotation;

    [Header("Stored Camera Information")]
    public Vector3 V3_CamForwardDirection; //used to store our cameras forward direction
    public Vector3 V3_CamRightDirection; //used to store our cameras right direction

    // Start is called before the first frame update
    void Start()
    {
        CC_PlayersCC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        DoInput();
        CalculateCamera();
        CalculateGround();
        DoMove();
        DoGravity();
        DoJump();

        CC_PlayersCC.Move(V3_Velocity * Time.deltaTime); //moves the player with the character Controller
    }

    void DoInput()
    {
        //Movement Section (1/2)
        V2_Input = new Vector2(Input.GetAxis("Horizontal_Keyboard"), Input.GetAxis("Vertical_Keyboard")); //Grabtranform Equal to new Vector2(GetIM_Hori, GetIM_Vert)
        V2_Input = Vector2.ClampMagnitude(V2_Input, 1); //Grab Input values and make them equal to a new "clamped" value. This smoothes out movement
    }

    void CalculateCamera()
    {
        //Camera Section (1/1)
        V3_CamForwardDirection = T_CameraObj.forward; //Sets the vector3 CamForDir to the cameras forward direction
        V3_CamRightDirection = T_CameraObj.right; //Sets the vector3 CamRighDir to the cameras right direction
        V3_CamForwardDirection.y = 0;
        V3_CamRightDirection.y = 0;
        V3_CamForwardDirection = V3_CamForwardDirection.normalized; //Normalize values
        V3_CamRightDirection = V3_CamRightDirection.normalized; //Normalize values
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        F_CurrentAngle = Vector3.Angle(Vector3.up, hit.normal); //Calc angle between normal and character
    }

    void CalculateGround()
    {
        //CC_PlayersCC.isGrounded
        //Physics.Raycast(transform.position + Vector3.up * 0.1f, -Vector3.up, out RCH_AmITouching, 0.2f) //Old code for collision detection
        if (CC_PlayersCC.isGrounded)
        {
            B_PlayerIsGrounded = true;
            //!!!!!!!!!!!!!!!!!insert slope value detection for preventing player from climbing mountains!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //also include a bool to switch from normal mode to slide mode?
        }
        else
        {
            B_PlayerIsGrounded = false;
        }
    }

    void DoMove()
    {
        //Movement Section  (2/2)
        //Both of these deleted codes have a problem where they move gameobject buts dont allow collision detection in real-time
        //transform.position += new Vector3(V2_Input.x, 0, V2_Input.y) * Time.deltaTime * F_Speed; // This moves the object but it isnt camera relative movement
        //transform.position += (V3_CamForwardDirection * V2_Input.y   +   V3_CamRightDirection * V2_Input.x) * Time.deltaTime * F_PlayerSpeed; //Moves object & it's camera relative direction movement
        //CC_PlayersCC.Move((V3_CamForwardDirection * V2_Input.y + V3_CamRightDirection * V2_Input.x) * Time.deltaTime * F_PlayerSpeed); //Moves object & it's camera relative direction movement
        V3_IntendedDirection = V3_CamForwardDirection * V2_Input.y + V3_CamRightDirection * V2_Input.x; //Compares the players direction and where the camera is looking

        F_CurrentTurnSpeed = V3_Velocity.magnitude / 5; // Current Speed we are running at
        F_PlayerTurnSpeed = Mathf.Lerp(F_PlayerHighestTurnSpeed, F_PlayerLowestTurnSpeed, F_CurrentTurnSpeed); //Caculating Needed Turn Speed

        if (V2_Input.magnitude > 0) //Only apply these if you actually doing input
        {
            Q_PlayerRotation = Quaternion.LookRotation(V3_IntendedDirection); //creates a rotation from the intended direction we give it

            transform.rotation = Quaternion.Lerp(transform.rotation, Q_PlayerRotation, F_PlayerTurnSpeed * Time.deltaTime); //rotates our character into that direction
        }

        V3_VelocityXZ = V3_Velocity; //added to assist vertical movement & to separate velocity into groups for modification
        V3_VelocityXZ.y = 0; //added to assist vertical movement & to separate velocity into groups for modification

        //V3_Velocity = V3_IntendedDirection * F_PlayerSpeed; // This instantly moves the player with no build up
        //V3_Velocity = Vector3.Lerp(V3_Velocity, V3_IntendedDirection * F_PlayerSpeed, F_Accerlation * Time.deltaTime); // This slowly moves the player to its speed instead of instantly having it
        V3_VelocityXZ = Vector3.Lerp(V3_VelocityXZ, transform.forward * V2_Input.magnitude * F_PlayerSpeed, F_Accerlation * Time.deltaTime);
        V3_Velocity = new Vector3(V3_VelocityXZ.x, V3_Velocity.y, V3_VelocityXZ.z); //added to assist vertical movement & to separate velocity into groups for modification
    }

    void DoGravity()
    {
        if (B_PlayerIsGrounded)
        {
            V3_Velocity.y = F_OnGroundGravity; //OnGround Gravity
        }
        else
        {
            V3_Velocity.y -= F_PlayerGravity * Time.deltaTime; //subtract velocity.y with gravity
            V3_Velocity.y = Mathf.Clamp(V3_Velocity.y, -10, 10); //limited the gravity & velocity !!!You can implement a hold jump longer to get higher here
        }
    }

    void DoJump()
    {
        if (B_PlayerIsGrounded == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                V3_Velocity.y = F_PlayerJumpHeight;
            }
        }
    }