using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject currentPlayer;
    //camera public values
    public float XMinRotation;
    public float XMaxRotation;
    [Range(1.0f, 10.0f)]
    public float Xsensitivity;
    [Range(1.0f, 10.0f)]
    public float Ysensitivity;
    private Camera cam;
    private float rotAroundX, rotAroundY;
    public Transform capsule;


    // Use this for initialization
    void Start()
    {
        cam = this.GetComponent<Camera>();
        rotAroundX = transform.eulerAngles.x;
        rotAroundY = transform.eulerAngles.y;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //currentCamera = StateSelect.instance.GetCamToMove();
       
        cam = GetComponentInChildren<Camera>();


        rotAroundX += Input.GetAxis("Mouse Y") * Xsensitivity;
        rotAroundY += Input.GetAxis("Mouse X") * Ysensitivity;

        // Clamp rotation values
        rotAroundX = Mathf.Clamp(rotAroundX, XMinRotation, XMaxRotation);

        CameraRotation();
    }

    private void CameraRotation()
    {
        capsule.transform.rotation = Quaternion.Euler(0, rotAroundY, 0); // rotation of parent (player body)
        transform.rotation = Quaternion.Euler(0, rotAroundY, 0); // rotation of parent (player body)
        cam.transform.rotation = Quaternion.Euler(-rotAroundX, rotAroundY, 0); // rotation of Camera
    }


}