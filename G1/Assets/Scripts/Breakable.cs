using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{

    public GameObject BrokenVer;
   void Break()
    {
        Instantiate(BrokenVer, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    if (collision.gameObject.tag == "Enemy")
    {
       
    }
}
