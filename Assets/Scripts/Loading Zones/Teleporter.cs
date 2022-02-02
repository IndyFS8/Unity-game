using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleporter : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(x, y, z);
    }
    
}
