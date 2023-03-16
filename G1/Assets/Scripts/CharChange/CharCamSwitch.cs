using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCamSwitch : MonoBehaviour
{
    public Camera normalCamera;
    public Camera charCam;

    public void OnTriggerEnter(Collider other)
    {
        //When the player gets close enough (into t$$anonymous$$s trigger's volume)
        //then we turn on the ramp Camera and temporarily turn off the normal one
        if (other.gameObject.tag == "Player")
        {
            SwitchToCharCamera();
        }
    }

   /* public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SwitchToNormalCamera();
        }
    }
*/
    private void SwitchToCharCamera()
    {
        charCam.enabled = true;
        Camera.main.gameObject.SetActive(false);
    }

    private void SwitchToNormalCamera()
    {
        charCam.enabled = false;
        //Camera.main.gameObject.SetActive(false);
    }
}
