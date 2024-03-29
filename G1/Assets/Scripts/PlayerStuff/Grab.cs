using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{

    /*
    to make this work you need to have this script on the player
    and put the "IsGrabbable" script on any item you want to be 
    capable of being picked up
    */

    // Reference to the character camera.
    [SerializeField] private Camera characterCamera;

    // Reference to the slot for holding picked item.
    [SerializeField] private Transform slot;

    // Reference to the currently held item.
    private PickableItem pickedItem;

    // Method called very frame.
    private void Update()
    {
        // Execute logic only on button pressed
        if (Input.GetButtonDown("Fire1")) // or whatever button you want for pickup
        {
            // Check if player picked some item already
            if (pickedItem)
            {
                // If yes, drop picked item
                DropItem(pickedItem);
            }
            else
            {
                // If no, try to pick item in front of the player
                // Create ray from center of the screen
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;

                // Shot ray to find object to pick
                if (Physics.Raycast(ray, out hit, 1.5f))
                {
                    // Check if object is pickable
                    var pickable = hit.transform.GetComponent<PickableItem>();

                    // If object has PickableItem class
                    if (pickable)
                    {
                        // Pick it
                        PickItem(pickable);
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Throw(pickedItem);
        }
    }

    // Method for picking up item
    private void PickItem(PickableItem item)
    {
        // Assign reference
        pickedItem = item;

        // Disable rigidbody and reset velocities
        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;

        // Set Slot as a parent
        item.transform.SetParent(slot);

        // Reset position and rotation
        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;
    }
    // Method for dropping item
    public void DropItem(PickableItem item)
    {
        // Remove reference
        pickedItem = null;

        // Remove parent
        item.transform.SetParent(null);

        // Enable rigidbody
        item.Rb.isKinematic = false;

        // Add force to throw item a little bit
        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
    }

    public void Throw(PickableItem item)
    {
        
        DropItem(pickedItem);
        item.Rb.AddForce(item.transform.forward * 20, ForceMode.VelocityChange); // shoots item forward
        item.Rb.AddForce(item.transform.up * 6, ForceMode.VelocityChange); // pushes item upward a little

    }
}