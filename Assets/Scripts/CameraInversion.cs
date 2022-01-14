using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraInversion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false
        CinemachineCore.GetInputAxis = getAxisCustom;
    }

    public float getAxisCustom(string axisName)
    {
        if (axisName == "Horizontal")
        {
            return -UnityEngine.Input.GetAxis("Horizontal");
        }
        else
            return UnityEngine.Input.GetAxis(axisName);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
