using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redSpin : MonoBehaviour
{

    public float speed;
    // Update is called once per frame
    void Update()
    {
        //rotates object to make it spin
        transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
        //DontDestroyOnLoad(gameObject);
    }
}
