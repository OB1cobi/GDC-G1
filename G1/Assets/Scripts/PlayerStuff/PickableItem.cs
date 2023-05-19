using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
public class PickableItem : MonoBehaviour
{

    /* 
    When you attactch the first script it should need a gameobject of the slot where the item 
    will go, every item with this script will be help in that slot.
    make sure any item you want to be able to be picked up has this script, otherwise it wont work
    */
    // Reference to the rigidbody
    private Rigidbody rb;
    public Rigidbody Rb => rb;

    private void Awake()
    {
        // Get reference to the rigidbody
        rb = GetComponent<Rigidbody>();
    }

    internal static void AddForce(Vector3 vector3)
    {
        throw new NotImplementedException();
    }
}
