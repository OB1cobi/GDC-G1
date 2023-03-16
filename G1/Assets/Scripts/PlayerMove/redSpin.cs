using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redSpin : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //rotates object to make it spin
        transform.Rotate(0f, 1 * Time.deltaTime, 0f, Space.Self); 
    }
}
