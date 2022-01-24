using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        CinemachineCore.GetInputAxis = GetAxisCustom;
    }
 
    public float GetAxisCustom(string axisName)
    {
        if (axisName == "Mouse X")
        {
            if (Input.GetMouseButtonDown(1))
            {
                return UnityEngine.Input.GetAxis("Mouse X");
            }
            else
            {
                return 0;
            }
            
        }
        else if (axisName == "Mouse Y")
        {
            if (Input.GetMouseButtonDown(1))
            {
                return UnityEngine.Input.GetAxis("Mouse Y");
            }
            else
            {
                return 0;
            }
        }
 
        return 0;
    }
}
