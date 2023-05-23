using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideIgnore : MonoBehaviour
{

    public GameObject firstCol;
    public GameObject secondCol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(firstCol.GetComponent<Collider>(), secondCol.GetComponent<Collider>(), true);
    }
}
